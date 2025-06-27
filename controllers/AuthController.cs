using Microsoft.AspNetCore.Mvc;
using TunavBackend.Models;
using TunavBackend.Models.Auth;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BCrypt.Net;

namespace TunavBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignIn(LoginRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.Password))
                return Unauthorized(new { message = "Email ou mot de passe incorrect" });

            var token = GenerateJwtToken(user);

            return Ok(new AuthResponse
            {
                Token = token,
                Role = user.Role.ToString(),
                Nom = user.Nom
            });
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(RegisterRequest request)
        {
            if (await _context.Users.AnyAsync(u => u.Email == request.Email))
                return Conflict(new { message = "Cet email est déjà utilisé." });

            var password = Guid.NewGuid().ToString("N").Substring(0, 8);
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            var user = new User
            {
                Nom = request.Nom,
                Email = request.Email,
                Role = request.Role,
                Password = hashedPassword
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            try
            {
                using var smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("ton_email@gmail.com", "mot_de_passe_application"),
                    EnableSsl = true
                };

                await smtp.SendMailAsync(new MailMessage
                {
                    From = new MailAddress("ton_email@gmail.com", "Tunav"),
                    To = { request.Email },
                    Subject = "Inscription réussie - mot de passe",
                    Body = $"Bienvenue {request.Nom},\n\nVoici votre mot de passe : {password}\n\nTunav équipe."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Utilisateur créé mais échec d'envoi de mail", error = ex.Message });
            }

            return Ok(new { message = "Inscription réussie, mot de passe envoyé par mail" });
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Nom),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

// Ajoute dans appsettings.json
/*
"Jwt": {
  "Key": "TRES_LONGUE_CLE_SECRETE_PERSONNALISEE"
}
*/

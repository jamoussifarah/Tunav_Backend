using TunavBackend.Models.Enums;

namespace TunavBackend.Models.Auth
{
    public class RegisterRequest
    {
        public string Nom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
    
}
namespace TunavBackend.Models.Auth
{
    public class AuthResponse
    {
        public string Token { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
    }
}
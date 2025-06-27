namespace TunavBackend.Models
{
    public class Franchise
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Ville { get; set; } = string.Empty;

        public int UserId { get; set; }  
        public User? User { get; set; }
    }
}
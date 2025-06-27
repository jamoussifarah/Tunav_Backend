namespace TunavBackend.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;
        public string Contenu { get; set; } = string.Empty;
        public DateTime DatePublication { get; set; } = DateTime.Now;

        public int UserId { get; set; }  
        public User? User { get; set; }
    }
}
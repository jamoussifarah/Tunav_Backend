using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TunavBackend.Models
{
    public class Blog
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;
        
        public string Contenu { get; set; } = string.Empty;
        public DateTime DatePublication { get; set; } = DateTime.Now;
        public string ImagePath { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int Likes { get; set; } = 0;
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
    public class BlogCreateRequest
    {
        public string Titre { get; set; } = string.Empty;
        public string Contenu { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new();
        public int UserId { get; set; }
        public IFormFile? Image { get; set; }
    }
        
  public class BlogUpdateRequest
    {
        public string Titre { get; set; }
        public string Contenu { get; set; }
        public IFormFile? NewImage { get; set; }
        public List<string> Tags { get; set; } = new();
    }      
}

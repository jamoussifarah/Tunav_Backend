using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TunavBackend.Models
{
    public class ProduitSansDevis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Categorie { get; set; } = string.Empty;
        public string Prix { get; set; } = string.Empty;

        public ICollection<CaracteristiqueProduitSansDevis> Caracteristiques { get; set; } = new List<CaracteristiqueProduitSansDevis>();
    }

    public class CaracteristiqueProduitSansDevis
    {
        [Key]
        public int Id { get; set; }

        public string Texte { get; set; } = string.Empty;

        public int ProduitSansDevisId { get; set; }

        [ForeignKey("ProduitSansDevisId")]
        public ProduitSansDevis? Produit { get; set; }
    }

    public class ProduitSansDevisCreateRequest
    {
        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Categorie { get; set; } = string.Empty;
        public string Prix { get; set; } = string.Empty;
        public List<string> Caracteristiques { get; set; } = new();
        public IFormFile? Image { get; set; }
    }

    public class ProduitSansDevisUpdateRequest
    {
        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Categorie { get; set; } = string.Empty;
        public string Prix { get; set; } = string.Empty;
        public List<string> Caracteristiques { get; set; } = new();
        public IFormFile? NewImage { get; set; }
    }
}

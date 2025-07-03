using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TunavBackend.Models
{
    public class ProduitAvecDevis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Categorie { get; set; } = string.Empty;

        public ICollection<CaracteristiqueProduitAvecDevis> Caracteristiques { get; set; } = new List<CaracteristiqueProduitAvecDevis>();
        public ICollection<Devis>? Devis { get; set; }
    }

    public class CaracteristiqueProduitAvecDevis
    {
        [Key]
        public int Id { get; set; }

        public string Texte { get; set; } = string.Empty;

        public int ProduitAvecDevisId { get; set; }

        [ForeignKey("ProduitAvecDevisId")]
        public ProduitAvecDevis? Produit { get; set; }
    }

    public class ProduitAvecDevisCreateRequest
    {
        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Categorie { get; set; } = string.Empty;
        public List<string> Caracteristiques { get; set; } = new();
        public IFormFile? Image { get; set; }
    }

    public class ProduitAvecDevisUpdateRequest
    {
        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Categorie { get; set; } = string.Empty;
        public List<string> Caracteristiques { get; set; } = new();
        public IFormFile? NewImage { get; set; }
    }
}

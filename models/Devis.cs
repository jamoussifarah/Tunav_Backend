using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TunavBackend.Models
{
    public class Devis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Entreprise { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public int Quantite { get; set; }

        public int UserId { get; set; }
        public User? userDevis { get; set; }
        public int? ProduitAvecDevisId { get; set; }
        public  ProduitAvecDevis? produitDevis { get; set; }
    }

    public class DevisCreateRequest
    {
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Entreprise { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public int Quantite { get; set; }
        public int UserId { get; set; }
        public int? ProduitAvecDevisId { get; set; }
    }
}
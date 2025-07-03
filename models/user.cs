using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TunavBackend.Models.Enums;
namespace TunavBackend.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Role Role { get; set; }
        public ICollection<Franchise>? Franchises { get; set; }
        public ICollection<Blog>? Blogs { get; set; }
        // 🔹 Lien avec les devis
        public ICollection<Devis>? Devis { get; set; }

        // 🔹 Lien avec les produits sans devis
        public ICollection<ProduitSansDevis>? ProduitsSansDevis { get; set; }
    }
}

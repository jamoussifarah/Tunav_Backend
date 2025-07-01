using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TunavBackend.Models
{
    public class Franchise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string ProfessionActuelle { get; set; }
        public string ExperienceIotGps { get; set; }
        public string EntrepriseDirige { get; set; }
        public string Motivation { get; set; }
        public int UserId { get; set; }  
    }
}
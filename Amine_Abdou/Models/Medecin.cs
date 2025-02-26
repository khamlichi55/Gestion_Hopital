using System.ComponentModel.DataAnnotations;

namespace Amine_Abdou.Models
{
    public class Medecin
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Le nom ne peut pas dépasser 50 caractères.")]
        public string Nom { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Le grade ne peut pas dépasser 10 caractères.")]
        public string Grade { get; set; }

        [Required]
        [Phone(ErrorMessage = "Le numéro de téléphone n'est pas valide.")]
        public string Tel { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "La spécialité ne peut pas dépasser 50 caractères.")]
        public string Specialite { get; set; }
    }

}

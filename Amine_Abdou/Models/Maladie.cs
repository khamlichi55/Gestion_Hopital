using System.ComponentModel.DataAnnotations;

namespace Amine_Abdou.Models
{
    public class Maladie
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le nom de la maladie ne peut pas dépasser 100 caractères.")]
        public string Nom { get; set; }

        [StringLength(500, ErrorMessage = "La description ne peut pas dépasser 500 caractères.")]
        public string Description { get; set; }
    }
}

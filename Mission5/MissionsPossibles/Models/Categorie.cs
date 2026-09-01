using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Mission.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "La {0} doit contenir entre {1} et {2} caractères.")]
        public string Titre { get; set; }

        [ValidateNever]
        public IList<Produit> Produits { get; set; }
    }
}


using System.ComponentModel.DataAnnotations;

namespace Practica7.WebAPI.Models
{
    public class CategoriesView
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(15)]
        public string name { get; set; }

        [StringLength(150)]
        public string description { get; set; }
    }
}
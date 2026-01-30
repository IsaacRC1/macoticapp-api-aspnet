using System.ComponentModel.DataAnnotations;

namespace trabajo_finall.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }

        [MaxLength(100)]
        [Required]
        public string nombre { get; set; }

        [Required]
        public decimal precio { get; set; }

        [Required]
        [EmailAddress]
        public int stock{ get; set; } 
    }
}



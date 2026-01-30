using System.ComponentModel.DataAnnotations;

namespace trabajo_finall.Dtos
{
    public class ProductoCreateDto
    {
        [Key]
        public int id { get; set; }

        [MaxLength(100)]
        [Required]
        public string nombre { get; set; }

        [Required]
        public decimal precio { get; set; }

        [Required]
        public int stock{ get; set; } 
    }
}

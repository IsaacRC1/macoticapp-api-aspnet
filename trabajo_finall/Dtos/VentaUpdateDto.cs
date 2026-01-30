using System.ComponentModel.DataAnnotations;

namespace trabajo_finall.Dtos
{
    public class VentaUpdateDto
    {
        [Key]
        public int id { get; set; }

        [Required]
        public DateTimeOffset fecha { get; set; }

        [Required]
        public decimal total { get; set; } 
    }
}



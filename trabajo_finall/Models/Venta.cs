using System.ComponentModel.DataAnnotations;

namespace trabajo_finall.Models
{
    public class Venta
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public DateTimeOffset fecha { get; set; }

        [Required]
        [EmailAddress]
        public decimal total { get; set; } 
    }
}



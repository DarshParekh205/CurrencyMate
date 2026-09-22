using System.ComponentModel.DataAnnotations;

namespace CurrencyX.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Symbol { get; set; } = string.Empty;
    }
}
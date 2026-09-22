using System.ComponentModel.DataAnnotations;

namespace CurrencyX.Models
{
    public class ConversionHistory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string FromCurrency { get; set; } = string.Empty;

        [Required]
        public string ToCurrency { get; set; } = string.Empty;

        public decimal ExchangeRate { get; set; }

        public decimal ConvertedAmount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
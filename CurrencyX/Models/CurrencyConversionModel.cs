using System.ComponentModel.DataAnnotations;

namespace CurrencyX.Models
{
    public class CurrencyConversionModel
    {
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public string FromCurrency { get; set; } = "USD";

        [Required]
        public string ToCurrency { get; set; } = "INR";

        public decimal Result { get; set; }

        public bool IsConverted { get; set; }

        public DateTime ConversionTime { get; set; }
    }
}

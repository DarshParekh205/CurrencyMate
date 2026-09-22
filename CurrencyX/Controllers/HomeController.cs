using CurrencyX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CurrencyX.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CurrencyConversionModel());
        }


        [HttpPost]
        public IActionResult Index(CurrencyConversionModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Dictionary<string, decimal> rates = new()
            {
                { "USD", 1.00m },
                { "INR", 83.00m },
                { "EUR", 0.92m },
                { "GBP", 0.79m },
                    { "JPY", 150.00m }
            };

            if (!rates.ContainsKey(model.FromCurrency) ||
                !rates.ContainsKey(model.ToCurrency))
            {
                ModelState.AddModelError("", "Invalid currency selected.");
                return View(model);
            }

            // Convert the amount to USD first
            decimal amountInUSD =
                model.Amount / rates[model.FromCurrency];

            // Convert USD to the target currency
            model.Result =
                         amountInUSD * rates[model.ToCurrency];

            model.IsConverted = true;

            // Store the current date and time
            model.ConversionTime = DateTime.Now;

            return View(model);

            return View(model);

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using CurrencyX.Data;
using CurrencyX.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CurrencyConverter.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CurrencyController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var currencies = await _context.Currencies.ToListAsync();

            return View(currencies);
        }
    }
}
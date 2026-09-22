using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CurrencyX.Controllers
{
    public class HistoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var history = await _context.ConversionHistories
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            return View(history);
        }
    }
}
using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class BolumSecController : Controller
    {
        public IActionResult Index()
        {
            HastaneRandevuSistemiDbContext _context = HastaneRandevuSistemiDbContext.getInstance();
            var bolumlerListesi = _context.BolumT.ToList();
            return View(bolumlerListesi);
        }

        [HttpPost]
        public IActionResult BolumSayfasi(int id) {
            HastaneRandevuSistemiDbContext _context = HastaneRandevuSistemiDbContext.getInstance();
            var query = from doktor in _context.DoktorT.ToList() where doktor.bolum_id == id select doktor;

            return View(query.ToList());
        }
    }
}

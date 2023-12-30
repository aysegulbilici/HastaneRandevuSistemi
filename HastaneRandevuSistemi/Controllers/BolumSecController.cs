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
    }
}

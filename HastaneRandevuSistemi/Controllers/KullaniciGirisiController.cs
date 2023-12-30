using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class KullaniciGirisiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Giris(Kullanici kullanici)
        {
            //TODO: mesaj goster.
            if (!ModelState.IsValid)
            {
                HastaneRandevuSistemiDbContext _context = HastaneRandevuSistemiDbContext.getInstance();

                // veri tabanı.
                var query = from x in _context.KullaniciT where x.Tc == kullanici.Tc && x.Sifre == kullanici.Sifre select x;

                if (query != null)
                    return RedirectToAction("Index", "BolumSec");
            }
            return View();
        }
    }
}

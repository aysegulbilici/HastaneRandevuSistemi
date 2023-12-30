using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class UyeOlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UyeOl(Kullanici kullanici)
        {
            //TODO: uye olma basarili mesaji goster.
            if (ModelState.IsValid)
            {
                HastaneRandevuSistemiDbContext _context = HastaneRandevuSistemiDbContext.getInstance();
                kullanici.rolId = 2;
                _context.Add(kullanici);
                _context.SaveChanges();
                return RedirectToAction("Giris","Giris"); // Başka bir sayfaya yönlendirilebilir.
            }
            return View(kullanici); // Hata durumunda aynı sayfaya geri dönebilir ve hataları gösterebilirsiniz.

        }


        public IActionResult Basarili()
        {
            return View();
        }
    }
}

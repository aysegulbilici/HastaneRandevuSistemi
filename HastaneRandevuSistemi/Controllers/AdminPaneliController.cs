using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class AdminPaneliController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult DoktorEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoktorEkle(DoktorDbo doktor)
        {
            // Burada doktor ekleme işlemleri yapılabilir
            // Örneğin, veritabanına doktor bilgilerini ekleyebilirsiniz.
            // Ardından başarı sayfasına yönlendirilebilir.
            HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
            Doktor d = doktor.getDoktor();
            d.randevu_id = "";
            _ctx.DoktorT.Add(d);
            _ctx.SaveChanges();
            return RedirectToAction("DoktorEklendi", doktor);
        }

        public IActionResult DoktorEklendi(DoktorDbo doktor)
        {
            if (ModelState.IsValid)
            {
                // Process the form submission, add the doktor to the database, etc.
                // ...

                // Return the DoktorEklendi view with the model
                return View("DoktorEklendi", doktor);
            }

            // If the ModelState is not valid, return the same view with validation errors
            return View("DoktorEkle", doktor);
        }
    }
}

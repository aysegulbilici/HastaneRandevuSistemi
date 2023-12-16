// UyeOlController.cs
using Microsoft.AspNetCore.Mvc;
using HastaneRandevuSistemi.Models; // UyeModel sınıfını ekleyin

namespace HastaneRandevuSistemi.Controllers
{
    public class UyeOlController : Controller
    {
        [HttpPost]
        public IActionResult UyeOl(UyeModel model)
        {
            // Burada model verilerini kullanarak gerekli işlemleri yapabilirsiniz
            // Örneğin, veritabanına kaydetme işlemi yapabilirsiniz

            // Başarılı bir şekilde üye olunduğunda başka bir sayfaya yönlendirme yapabilirsiniz
            return RedirectToAction("BasariliUyeOl", "UyeOl");
        }

        // UyeOlController.cs
        public IActionResult BasariliUyeOl()
        {
            // Üyelik başarılı sayfasına yönlendirme yapabilirsiniz
            return View();
        }

    }
}

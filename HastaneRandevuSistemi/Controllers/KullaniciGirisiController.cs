using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class KullaniciGirisiController : Controller
    {
        public IActionResult KullaniciGirisi()
        {
            return View();
        }
    }
}

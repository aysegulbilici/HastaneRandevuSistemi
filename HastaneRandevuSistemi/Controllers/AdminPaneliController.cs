using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class AdminPaneliController : Controller
    {
        public IActionResult AdminPaneli()
        {
            return View();
        }
    }
}

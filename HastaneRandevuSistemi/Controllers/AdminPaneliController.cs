using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HastaneRandevuSistemi.Controllers
{
    public class AdminPaneliController : Controller
    {
        public AdminPaneliController() { }
		public IActionResult Index() { return View(); }

		[HttpPost]
		public IActionResult Giris(Admin admin) { return View(); }
	}
}

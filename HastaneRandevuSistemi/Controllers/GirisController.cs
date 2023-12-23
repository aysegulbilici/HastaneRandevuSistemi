using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class GirisController : Controller
    {
        public IActionResult Giris()
        {
            HastaneRandevuSistemiDbContext context= HastaneRandevuSistemiDbContext.getInstance();
            var res = context.RolT.ToList();

            return View(res);
        }
    }
}

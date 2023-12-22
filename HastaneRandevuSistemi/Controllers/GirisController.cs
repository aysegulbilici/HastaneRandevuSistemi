using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class GirisController : Controller
    {
        public IActionResult Giris()
        {
            HastaneRandevuSistemiDbContext s= HastaneRandevuSistemiDbContext.getInstance();
            Rol rol = new Rol();
            rol.rolId = 5;
            rol.rolAd = "dumb1";
            s.Add(rol);
            s.SaveChanges();


            return View();
        }
    }
}

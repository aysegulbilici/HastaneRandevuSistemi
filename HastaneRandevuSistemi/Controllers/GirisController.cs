using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class GirisController : Controller
    {
        public IActionResult Giris()
        {
            return View();
        }

        public IActionResult DoktorGirisi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoktorGirisi(DoktorGiris d)
        {
            if(ModelState.IsValid)
            {
                HastaneRandevuSistemiDbContext _ctx=HastaneRandevuSistemiDbContext.getInstance();
                var query = from x in _ctx.KullaniciT where x.Tc.Equals(d.Tc) && x.Sifre.Equals(d.Sifre) select x;
                if (query.FirstOrDefault()!.rolId == 3)
                    return View("GirisBasarili");
			}
			return View("Error");
		}

        public IActionResult HastaGirisi()
        {

            return View();
        }

        [HttpPost]
        public IActionResult HastaGirisi(HastaGiris h)
        {
            // TODO:Session
			if (ModelState.IsValid)
			{
				HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
				var query = from x in _ctx.KullaniciT where x.Tc.Equals(h.Tc) && x.Sifre.Equals(h.Sifre) select x;
				if (query.FirstOrDefault()!.rolId == 2)
					return View("GirisBasarili");
			}
			return View("Error");
        }
    }
}

using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HastaneRandevuSistemi.Controllers
{
    public class HastaController : Controller
    {
        public ActionResult Index()
        {
            HastaneRandevuSistemiDbContext context = HastaneRandevuSistemiDbContext.getInstance();
            return View(context.HastaT.Include(d => d.Kullanici).ToList());
        }


        // GET: HastaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HastaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HastaDbo h)
        {
            try
            {
                HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
                Hasta hasta = h.GetHasta();
                hasta.Kullanici.rolId = 2;
                _ctx.HastaT.Add(hasta);
                HastaneRandevuSistemiDbContext.getInstance().SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: DoktorController/Details/5
        public ActionResult Details(int id)
        {
            // randevulari goster
            HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
            var hasta = from x in _ctx.HastaT.Include(d => d.Kullanici) where x.id == id select x;

            var randevuListesi = _ctx.RandevuT
    .Include(d => d.Kullanici)
    .Include(d => d.Doktor)  // Include Dkotor property
    .ToList();

            var randevu = from x in randevuListesi where x.kullaniciId == id select x;
            ViewBag.Randevular = randevu.ToList();
            return View(hasta.FirstOrDefault()!);
        }



        // GET: HastaController/Delete/5
        public ActionResult Delete(int id)
        {
            HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
            var hastaList = _ctx.HastaT
     .Include(d => d.Kullanici)
     .ToList();
            var query = from d in hastaList where d.id.Equals(id) select d;
            TempData["hasta"] = query.FirstOrDefault()!;
            return View();
        }

        // POST: HastaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
                var hastaList = _ctx.HastaT
     .Include(d => d.Kullanici)
     .ToList();

                var kullaniciListesi = _ctx.KullaniciT;
                var query = from d in hastaList where d.id.Equals(id) select d;
                var queryK = from k in kullaniciListesi where k.KullaniciId == id select k;
                _ctx.HastaT.Remove(query.FirstOrDefault()!);
                _ctx.KullaniciT.Remove(queryK.FirstOrDefault()!);
                _ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // TODO: TODO
        // GET: HastaController/Edit/5
        public ActionResult Edit(int id)
        {
            HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
            ViewBag.Randevular = _ctx.RandevuT.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DoktorEditViewModel model)
        {
            try
            {
                HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
                var doktor = _ctx.DoktorT
                    .Include(d => d.Kullanici)
                    .Include(d => d.Bolum)
                    .FirstOrDefault(x => x.id == model.Id);

                if (doktor != null)
                {
                    doktor.bolum_id = model.BolumId;
                    _ctx.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        public ActionResult Giris()
        {
            return View();
        }
        // POST: HastaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Giris(HastaGiris h)
        {
            if (ModelState.IsValid)
            {
                HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
                var query = from x in _ctx.KullaniciT where x.Tc.Equals(h.Tc) && x.Sifre.Equals(h.Sifre) select x;
                ViewData["Title"] = h.Tc;
                var kullanici = query.FirstOrDefault();
                if (kullanici?.rolId == 2)
                {
                    return View("Main"); // Corrected view name
                }
                return View();
            }
            return View("Error");
        }




        public ActionResult Ayarlar(int id)
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ayarlar(SifreDegisModel model)
        {
            if (ModelState.IsValid)
            {
                HastaneRandevuSistemiDbContext _ = HastaneRandevuSistemiDbContext.getInstance();
                // Retrieve id from the model
                int id = model.id;
                // Fetch the corresponding Hasta record from the database

                Hasta hasta = _.HastaT.Include(h => h.Kullanici).FirstOrDefault(h => h.Kullanici.KullaniciId == model.id);

                // Check if the EskiSifre matches the current password
                if (hasta?.Kullanici?.Sifre != model.EskiSifre)
                {
                    ModelState.AddModelError("EskiSifre", "Eski şifre yanlış");
                    return View();
                }

                // Update the password
                hasta.Kullanici.Sifre = model.YeniSifre;

                // Save changes to the database
                _.HastaT.Update(hasta);
                _.SaveChanges();

                return RedirectToAction("Index"); // Redirect to the appropriate action
            }

            return View();
        }


        public ActionResult RandevuAl()
        {
            


            return View();



        }

    }
}

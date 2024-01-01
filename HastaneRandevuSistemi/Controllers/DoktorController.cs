using HastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HastaneRandevuSistemi.Controllers
{
    public class DoktorController : Controller
    {
        // GET: DoktorController
        public ActionResult Index()
        {
            HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
            var doktorList = _ctx.DoktorT
     .Include(d => d.Kullanici)
     .Include(d => d.Bolum)  // Include Bolum property
     .ToList();

            return View(doktorList);
        }

        // GET: DoktorController/Details/5
        public ActionResult Details(int id)
        {
            // randevulari goster
            HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
         
            var randevuListesi = _ctx.RandevuT
    .Include(d => d.Kullanici)
    .Include(d => d.Doktor)  // Include Dkotor property
    .ToList();

            var doktorList = _ctx.DoktorT
    .Include(d => d.Kullanici)
    .Include(d => d.Bolum)  // Include Bolum property
    .ToList();



            var randevu = from x in randevuListesi where x.doktorId ==id select x;

            var doktor = from x in doktorList where x.id == id select x;
            ViewBag.Randevular = randevu.ToList();
            ViewBag.Doktor = doktor;
            return View(doktor.FirstOrDefault()!);
        }

        // GET: DoktorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoktorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DoktorDbo dbo)
        {
            try
            {
                HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
                Doktor d = dbo.getDoktor(_ctx);

                _ctx.DoktorT.Add(d);
                _ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoktorController/Edit/5
        public ActionResult Edit(int id)
        {
            HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
            ViewBag.Bolumler = _ctx.BolumT.ToList();
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


        // GET: DoktorController/Delete/5
        public ActionResult Delete(int id)
        {
            HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
            var doktorList = _ctx.DoktorT
     .Include(d => d.Kullanici)
     .Include(d => d.Bolum)  // Include Bolum property
     .ToList();
            var query = from d in doktorList where d.id.Equals(id) select d;
            TempData["doktor"] = query.FirstOrDefault()!;
            return View();
        }

        // POST: DoktorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                HastaneRandevuSistemiDbContext _ctx = HastaneRandevuSistemiDbContext.getInstance();
                var doktorList = _ctx.DoktorT
      .Include(d => d.Kullanici)
      .Include(d => d.Bolum)  // Include Bolum property
      .ToList();

                var kullaniciListesi = _ctx.KullaniciT;
                var query = from d in doktorList where d.id.Equals(id) select d;
                var queryK = from k in kullaniciListesi where k.KullaniciId == id select k;
                _ctx.DoktorT.Remove(query.FirstOrDefault()!);
                _ctx.KullaniciT.Remove(queryK.FirstOrDefault()!);
                _ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

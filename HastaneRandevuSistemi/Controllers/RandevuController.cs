using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HastaneRandevuSistemi.Controllers
{
    public class RandevuController : Controller
    {
        // GET: RandevuController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RandevuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RandevuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RandevuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RandevuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RandevuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RandevuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RandevuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

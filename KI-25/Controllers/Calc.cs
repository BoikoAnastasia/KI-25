using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KI_25.Controllers
{
    public class Calc : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        // GET: Calc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calc/Create
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

        // GET: Calc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calc/Edit/5
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

        // GET: Calc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calc/Delete/5
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

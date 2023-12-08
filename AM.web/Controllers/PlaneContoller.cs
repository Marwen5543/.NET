using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AM.web.Controllers
{
    public class PlaneController : Controller
    {
        IServicePlane pl;
        public PlaneController(IServicePlane pl)
        {
            this.pl = pl;
        }
        // GET: PlaneContoller
        public ActionResult Index()
        {
            return View(pl.GetAll());
        }

        // GET: PlaneContoller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlaneContoller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlaneContoller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Plane plane)
        {
            try
            {
                pl.Add(plane);
                pl.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PlaneContoller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlaneContoller/Edit/5
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

        // GET: PlaneContoller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlaneContoller/Delete/5
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolPoliApp.Web.Controllers
{
    public class DepartmentApiController : Controller
    {
        // GET: DepartmentApiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DepartmentApiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmentApiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentApiController/Create
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

        // GET: DepartmentApiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartmentApiController/Edit/5
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

        // GET: DepartmentApiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartmentApiController/Delete/5
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

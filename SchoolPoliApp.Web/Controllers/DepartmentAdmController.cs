using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolPoliApp.Application.Dtos.Department;
using SchoolPoliApp.Application.Interfaces;

namespace SchoolPoliApp.Web.Controllers
{
    public class DepartmentAdmController : Controller
    {
        private readonly IDepartmentService departmentService;

        public DepartmentAdmController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }
        // GET: DepartmentAdmController
        public async Task<IActionResult> Index()
        {
            var result = await departmentService.GetAll();
            if (result.Success) 
            {
                List<DepartmentDto> departmentList = (List<DepartmentDto>)result.Data;

                return View(departmentList);
            }
            //departments.
            return View();
        }

        // GET: DepartmentAdmController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmentAdmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentAdmController/Create
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

        // GET: DepartmentAdmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartmentAdmController/Edit/5
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

        // GET: DepartmentAdmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartmentAdmController/Delete/5
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

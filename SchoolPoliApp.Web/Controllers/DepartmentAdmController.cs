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
        public async Task<IActionResult> Details(int id)
        {
            var result = await departmentService.GetById(id);

            if (result.Success)
            {
                DepartmentDto departmentList = (DepartmentDto)result.Data;
                return View(departmentList);
            }
            //departments.
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
        public async Task<IActionResult> Create(SaveDepartmentDto saveDepartmentDto)
        {
            try
            {
                var result = await this.departmentService.Save(saveDepartmentDto);

                if (result.Success)
                    return RedirectToAction(nameof(Index));


                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentAdmController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var result = await departmentService.GetById(id);

            if (result.Success)
            {
                DepartmentDto departmentList = (DepartmentDto)result.Data;
                return View(departmentList);
            }
            //departments.
            return View();
        }

        // POST: DepartmentAdmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateDepartmentDto updateDepartmentDto)
        {
            try
            {
                var result = await this.departmentService.Update(updateDepartmentDto);
                if (result.Success)
                    return RedirectToAction(nameof(Index));


                return View();

            }
            catch
            {
                return View();
            }
        }


    }
}

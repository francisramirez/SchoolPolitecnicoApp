using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolPoliApp.Application.Dtos.Department;
using SchoolPoliApp.Application.Interfaces;

namespace SchoolPoliApp.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        // GET: DepartmentController
        public async Task<IActionResult> Index()
        {
            var result = await _departmentService.GetAll();

            if (result.Success)
            {
                List<DepartmentDto> departmentList = (List<DepartmentDto>)result.Data;
                return View(departmentList);
            }
            return View();
        }

        // GET: DepartmentController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var result = await _departmentService.GetById(id);

            if (result.Success)
            {
                DepartmentDto departmentDto = (DepartmentDto)result.Data;
                return View(departmentDto);
            }

            return View();
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SaveDepartmentDto saveDepartmentDto)
        {
            try
            {
                await _departmentService.Save(saveDepartmentDto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _departmentService.GetById(id);

            if (result.Success)
            {
                DepartmentDto departmentDto = (DepartmentDto)result.Data;
                return View(departmentDto);
            }

            return View();
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateDepartmentDto updateDepartment)
        {
            try
            {
                await _departmentService.Update(updateDepartment);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

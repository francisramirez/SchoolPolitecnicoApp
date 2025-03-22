using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolPoliApp.WebApi.Models.Department;

namespace SchoolPoliApp.WebApi.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: DepartmentController
        public async Task<IActionResult> Index()
        {
            List<DepartmentModel> departments = new List<DepartmentModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5175/api/");

                var response = await client.GetAsync("Departament/GetDepartments");

                if (response.IsSuccessStatusCode)
                    departments = await response.Content.ReadFromJsonAsync<List<DepartmentModel>>();
                else
                {
                    ViewBag.Message = "Error obteniendo los departamentos.";
                    return View();
                }


            }
            return View(departments);
        }

        // GET: DepartmentController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            DepartmentModel department = new DepartmentModel();


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5175/api/");

                var response = await client.GetAsync($"Departament/GetDepartmentById?id={id}");

                if (response.IsSuccessStatusCode)
                    department = await response.Content.ReadFromJsonAsync<DepartmentModel>();
                else
                {
                    ViewBag.Message = "Error obteniendo los departamentos.";
                    return View();
                }


            }
            return View(department);
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartmentModel department)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5175/api/");

                    var response = await client.PostAsJsonAsync<DepartmentModel>($"Departament/UpdateDepartment", department);

                    if (response.IsSuccessStatusCode)
                        operationResult = await response.Content.ReadFromJsonAsync<OperationResult>();
                    else
                    {
                        ViewBag.Message = "Error guardando el departamento.";
                        return View();
                    }

                }

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
            DepartmentModel department = new DepartmentModel();


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5175/api/");

                var response = await client.GetAsync($"Departament/GetDepartmentById?id={id}");

                if (response.IsSuccessStatusCode)
                    department = await response.Content.ReadFromJsonAsync<DepartmentModel>();
                else
                {
                    ViewBag.Message = "Error obteniendo el departamento.";
                    return View();
                }


            }
            return View(department);
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DepartmentModel department)
        {
            OperationResult operationResult = new OperationResult();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5175/api/");

                    var response = await client.PostAsJsonAsync<DepartmentModel>($"Departament/UpdateDepartment", department);

                    if (response.IsSuccessStatusCode)
                        operationResult = await response.Content.ReadFromJsonAsync<OperationResult>();
                    else
                    {
                        ViewBag.Message = "Error actualizando el departamento.";
                        return View();
                    }

                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}

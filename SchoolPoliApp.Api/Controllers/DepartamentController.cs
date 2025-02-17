using Microsoft.AspNetCore.Mvc;
using SchoolPoliApp.Domain.Entities;
using SchoolPoliApp.Persistence.Interfaces;
 
namespace SchoolPoliApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartamentController(IDepartmentRepository departmentRepository,
                                     ILogger<DepartamentController> logger)
        {
            _departmentRepository = departmentRepository;
        }
        
        [HttpGet("GetDepartments")]
        public async Task<IActionResult> Get()
        {

            var departments = await _departmentRepository.GetAllAsync();
            return Ok(departments);
        }

       
        [HttpGet("GetDepartmentById")]
        public async Task<IActionResult> Get(int id)
        {
            var departments = await _departmentRepository.GetEntityByIdAsync(id);
            return Ok(departments);
        }

       
        [HttpPost("SaveDepartment")]
        public async Task<IActionResult> Post([FromBody] Department department)
        {
            var departments = await _departmentRepository.SaveEntityAsync(department);
            return Ok(departments);
        }

       
        [HttpPost("UpdateDepartment")]
        public async Task<IActionResult> Put([FromBody] Department department)
        {
            var departments = await _departmentRepository.UpdateEntityAsync(department);
            return Ok(departments);
        }

       
    }
}

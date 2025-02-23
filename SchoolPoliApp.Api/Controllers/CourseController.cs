using Microsoft.AspNetCore.Mvc;
using SchoolPoliApp.Persistence.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPoliApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ILogger<CourseController> _logger;

        public CourseController(ICourseRepository courseRepository, ILogger<CourseController> logger)
        {
            _courseRepository = courseRepository;
            _logger = logger;
        }
      
        [HttpGet("GetCourses")]
        public async Task<IActionResult> Get()
        {
            var result =  await _courseRepository.GetAllAsync();

            return Ok(result);
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

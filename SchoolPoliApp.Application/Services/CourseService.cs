

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SchoolPoliApp.Application.Dtos.Courses;
using SchoolPoliApp.Application.Interfaces;
using SchoolPoliApp.Domain.Base;
using SchoolPoliApp.Persistence.Interfaces;

namespace SchoolPoliApp.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ILogger<CourseService> _logger;
        private readonly IConfiguration _configuration;

        public CourseService(ICourseRepository courseRepository, 
                             ILogger<CourseService> logger, 
                             IConfiguration configuration)
        {
            _courseRepository = courseRepository;
            _logger = logger;
            _configuration = configuration;
        }
        public Task<OperationResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> GetCourseByDepartment(int departmentId)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> Remove(RemoveCourseDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> Save(SaveCourseDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> Update(UpdateCourseDto dto)
        {
            throw new NotImplementedException();
        }
    }
}

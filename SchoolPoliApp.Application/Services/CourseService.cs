

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

        public Task<OperationResult> GetById(int Id)
        {
            OperationResult result = new OperationResult();

            try
            {

                result = _courseRepository.GetEntityByIdAsync(Id);
            }
            catch (Exception ex)
            {

                result.Message = "Error obteniendo el curso.";
                result.Success = false;
                _logger.LogError(result.Message, ex);
            }
        }

        public Task<OperationResult> GetCourseByDepartment(int departmentId)
        {
            OperationResult result = new OperationResult();
            try
            {
               
            }
            catch (Exception)
            {

                result.Message = "Error obteniendo el curso.";
                result.Success = false;
                _logger.LogError(result.Message, ex);
            }
        }

        public Task<OperationResult> Remove(RemoveCourseDto dto)
        {
            OperationResult result = new OperationResult();
            try
            {

            }
            catch (Exception)
            {

                result.Message = "Error obteniendo el curso.";
                result.Success = false;
                _logger.LogError(result.Message, ex);
            }
        }

        public Task<OperationResult> Save(SaveCourseDto dto)
        {
            OperationResult result = new OperationResult();
            try
            {

            }
            catch (Exception)
            {

                result.Message = "Error obteniendo el curso.";
                result.Success = false;
                _logger.LogError(result.Message, ex);
            }
        }

        public Task<OperationResult> Update(UpdateCourseDto dto)
        {
            OperationResult result = new OperationResult();
            try
            {

            }
            catch (Exception)
            {

                result.Message = "Error obteniendo el curso.";
                result.Success = false;
                _logger.LogError(result.Message, ex);
            }
        }
    }
}

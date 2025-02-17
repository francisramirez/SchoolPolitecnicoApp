

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SchoolPoliApp.Domain.Base;
using SchoolPoliApp.Domain.Entities;
using SchoolPoliApp.Model.Models;
using SchoolPoliApp.Persistence.Base;
using SchoolPoliApp.Persistence.Context;
using SchoolPoliApp.Persistence.Interfaces;

namespace SchoolPoliApp.Persistence.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        private readonly SchoolContext _context;
        private readonly ILogger<CourseRepository> _logger;
        private readonly IConfiguration _configuration;

        public CourseRepository(SchoolContext context,
                                ILogger<CourseRepository> logger,
                                IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }
        public async Task<OperationResult> GetCourseByDepartmentId(int departmentId)
        {
            OperationResult result = new OperationResult();

            try
            {
                var querys = await (from course in _context.Courses
                             join depto in _context.Departments on course.DepartmentId equals depto.Id
                             where course.DepartmentId == departmentId
                             select new CourseDepartmenModel()
                             {
                                 CourseId = course.Id,
                                 CreationDate = course.CreationDate,
                                 Credits = course.Credits,
                                 DepartmentId = depto.Id, 
                                 DepartmentName = depto.Name,
                                 Title = course.Title,
                             }).ToListAsync();

                result.Data = querys;

            }
            catch (Exception ex)
            {
                result.Message = this._configuration["ErrorCourseRepository:GetCourseByDepartment"];
                result.Success = false;
                this._logger.LogError(result.Message,ex.ToString());
            }
            return result;
        }
        public override Task<OperationResult> SaveEntityAsync(Course entity)
        {
            return base.SaveEntityAsync(entity);
        }
        public override Task<OperationResult> UpdateEntityAsync(Course entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}

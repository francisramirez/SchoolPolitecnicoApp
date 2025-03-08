

using SchoolPoliApp.Application.Base;
using SchoolPoliApp.Application.Dtos.Courses;
using SchoolPoliApp.Domain.Base;


namespace SchoolPoliApp.Application.Interfaces
{
    public interface ICourseService : IBaseService<SaveCourseDto,UpdateCourseDto,RemoveCourseDto>
    {
        Task<OperationResult> GetCourseByDepartment(int departmentId);
    }
}



using SchoolPoliApp.Domain.Entities;
using SchoolPoliApp.Domain.Repository;
using SchoolPoliApp.Domain.Base;

namespace SchoolPoliApp.Persistence.Interfaces
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        Task<OperationResult> GetCourseByDepartmentId(int departmentId);
    }
}

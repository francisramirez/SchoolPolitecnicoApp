

using SchoolPoliApp.Application.Base;
using SchoolPoliApp.Application.Dtos.Department;
using SchoolPoliApp.Domain.Base;

namespace SchoolPoliApp.Application.Interfaces
{
    public interface IDepartmentService : IBaseService<SaveDepartmentDto,UpdateDepartmentDto,RemoveDepartmentDto>
    {
        
    }
}

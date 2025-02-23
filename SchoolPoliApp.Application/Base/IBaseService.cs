
using SchoolPoliApp.Domain.Base;

namespace SchoolPoliApp.Application.Base
{
    public interface IBaseService<TDtoSave, TDtoUpdate, TDtoRemove>
    {
        Task<OperationResult> GetAll();
        Task<OperationResult> GetById(int Id);
        Task<OperationResult> Update(TDtoUpdate dto);
        Task<OperationResult> Remove(TDtoRemove dto);
        Task<OperationResult> Save(TDtoSave dto);
    }
}

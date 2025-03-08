

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SchoolPoliApp.Application.Dtos.Department;
using SchoolPoliApp.Application.Exceptions;
using SchoolPoliApp.Application.Interfaces;
using SchoolPoliApp.Domain.Base;
using SchoolPoliApp.Domain.Entities;
using SchoolPoliApp.Persistence.Interfaces;

namespace SchoolPoliApp.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILogger<DepartmentService> _logger;
        private readonly IConfiguration _configuration;

        public DepartmentService(IDepartmentRepository departmentRepository,
                                 ILogger<DepartmentService> logger,
                                 IConfiguration configuration)
        {
            _departmentRepository = departmentRepository;
            _logger = logger;
            _configuration = configuration;
        }
        public async Task<OperationResult> GetAll()
        {
            OperationResult result = new OperationResult();

            try
            {
                result.Data = (await _departmentRepository.GetAllAsync())
                    .Select(depto => new Dtos.Department.DepartmentDto()
                    {
                        Administrator = depto.Administrator,
                        Budget = depto.Budget,
                        ChangeDate = depto.CreationDate,
                        Name = depto.Name,
                        StartDate = depto.StartDate,
                        ChangeUser = depto.CreationUser,
                        DepartmentId = depto.Id
                    }).OrderByDescending(cd => cd.ChangeDate).ToList();

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error obteniendo los departamentos";
                _logger.LogError(result.Message, ex);
            }
            return result;
        }

        public async Task<OperationResult> GetById(int Id)
        {
            OperationResult result = new OperationResult();

            try
            {
                var depto = await _departmentRepository.GetEntityByIdAsync(Id);

                var deptoResult = new DepartmentDto()
                {
                    Administrator = depto.Administrator,
                    Budget = depto.Budget,
                    ChangeDate = depto.CreationDate,
                    Name = depto.Name,
                    StartDate = depto.StartDate,
                    ChangeUser = depto.CreationUser,
                    DepartmentId = depto.Id
                };

                result.Data = deptoResult;
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo el departamento";
                _logger.LogError(result.Message, ex);
            }

            return result;
        }

        public Task<OperationResult> Remove(RemoveDepartmentDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult> Save(SaveDepartmentDto dto)
        {
            OperationResult result = new OperationResult();
            try
            {
                result = await _departmentRepository.SaveEntityAsync(new Department()
                {
                    Administrator = dto.Administrator,
                    Budget = dto.Budget,
                    CreationDate = dto.ChangeDate,
                    Name = dto.Name,
                    CreationUser = dto.ChangeUser,
                    StartDate = dto.StartDate
                });
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error guardando el departamento";
                _logger.LogError(result.Message, ex);
            }
            return result;
        }
        public async Task<OperationResult> Update(UpdateDepartmentDto dto)
        {
            OperationResult result = new OperationResult { Success = false };

            try
            {
                var deptoToUpdate = await _departmentRepository.GetEntityByIdAsync(dto.Id);
                deptoToUpdate.Administrator = dto.Administrator;
                deptoToUpdate.Budget = dto.Budget;
                deptoToUpdate.StartDate = dto.StartDate;
                deptoToUpdate.ModifyDate = dto.ChangeDate;
                deptoToUpdate.UserMod = dto.ChangeUser;
                deptoToUpdate.Name = dto.Name;
                
                await _departmentRepository.UpdateEntityAsync(deptoToUpdate);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error actualizando el departamento";
                _logger.LogError(result.Message, ex);
            }

            return result;
        }
    }
}

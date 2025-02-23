

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SchoolPoliApp.Application.Dtos.Department;
using SchoolPoliApp.Application.Interfaces;
using SchoolPoliApp.Domain.Base;
using SchoolPoliApp.Persistence.Interfaces;
using SchoolPoliApp.Persistence.Repositories;

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
        public Task<OperationResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetById(int Id)
        {
            throw new NotImplementedException();
        }
       
        public Task<OperationResult> Remove(RemoveDepartmentDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Save(SaveDepartmentDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> Update(UpdateDepartmentDto dto)
        {
            throw new NotImplementedException();
        }
    }
}

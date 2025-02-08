
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SchoolPoliApp.Domain.Base;
using SchoolPoliApp.Domain.Entities;
using SchoolPoliApp.Persistence.Base;
using SchoolPoliApp.Persistence.Context;
using SchoolPoliApp.Persistence.Interfaces;

namespace SchoolPoliApp.Persistence.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        private readonly SchoolContext _context;
        private readonly ILogger<DepartmentRepository> _logger;
        private readonly IConfiguration _configuration;

        public DepartmentRepository(SchoolContext context, 
                                    ILogger<DepartmentRepository> logger, 
                                    IConfiguration configuration) :base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }
        public override Task<OperationResult> SaveEntityAsync(Department entity)
        {
            ///agregar las validaciones correspondientes //
            ///


            return base.SaveEntityAsync(entity);
        }
        public override Task<OperationResult> UpdateEntityAsync(Department entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}

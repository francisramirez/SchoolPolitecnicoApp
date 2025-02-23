



using Microsoft.Extensions.DependencyInjection;
using SchoolPoliApp.Application.Interfaces;
using SchoolPoliApp.Application.Services;
using SchoolPoliApp.Persistence.Interfaces;
using SchoolPoliApp.Persistence.Repositories;

namespace SchoolPoliApp.IOC.Dependencies
{
    public static class DepartamentDependency
    {
        public static void AddDepartamentDependency(this IServiceCollection service) 
        {
            service.AddScoped<IDepartmentRepository, DepartmentRepository>();
            service.AddTransient<IDepartmentService, DepartmentService>();
        }
    }
}

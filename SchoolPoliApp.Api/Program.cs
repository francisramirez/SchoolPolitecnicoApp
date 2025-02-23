
using Microsoft.EntityFrameworkCore;
using SchoolPoliApp.Persistence.Context;
using SchoolPoliApp.Persistence.Interfaces;
using SchoolPoliApp.Persistence.Repositories;
using SchoolPoliApp.IOC.Dependencies;
namespace SchoolPoliApp.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container

            builder.Services.AddDbContext<SchoolContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDb")));

            builder.Services.AddDepartamentDependency();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

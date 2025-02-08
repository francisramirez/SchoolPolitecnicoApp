

using Microsoft.EntityFrameworkCore;
using SchoolPoliApp.Domain.Entities;

namespace SchoolPoliApp.Persistence.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students  { get; set; }
    }
}

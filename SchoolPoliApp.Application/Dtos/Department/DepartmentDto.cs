
namespace SchoolPoliApp.Application.Dtos.Department
{
    public class DepartmentDto : DtoBase
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int Administrator { get; set; }

    }
}

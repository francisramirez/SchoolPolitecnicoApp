

namespace SchoolPoliApp.Model.Models
{
    public class DepartmentGetModel
    {
        public int DepartmentID { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; } 
        public DateTime StartDate { get;set; }
        public int? Administrator { get; set; }
    }
}

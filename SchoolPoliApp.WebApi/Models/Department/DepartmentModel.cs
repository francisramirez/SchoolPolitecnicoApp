namespace SchoolPoliApp.WebApi.Models.Department
{
    public class DepartmentModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public double budget { get; set; }
        public DateTime startDate { get; set; }
        public int administrator { get; set; }
        public DateTime creationDate { get; set; }
        public int creationUser { get; set; }
        public DateTime? modifyDate { get; set; }
        public int? userMod { get; set; }
        public object userDeleted { get; set; }
        public bool deleted { get; set; }

    }
}

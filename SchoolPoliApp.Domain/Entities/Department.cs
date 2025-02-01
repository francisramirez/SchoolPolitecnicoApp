

using SchoolPoliApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPoliApp.Domain.Entities
{
    public sealed class Department : Base.BaseEntity<int>
    {
        [Column("DepartmentID")]
        [Key]
        public override int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int Administrator { get; set; }


    }
}

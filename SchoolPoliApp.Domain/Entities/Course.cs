

using SchoolPoliApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPoliApp.Domain.Entities
{
    [Table("Courses")]
    public sealed class Course : Base.BaseEntity<int>
    {

        [Column("CourseID")]
        [Key]
        public override int Id { get; set; }
       
        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentId { get; set; }
    }
}



using SchoolPoliApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPoliApp.Domain.Entities
{
    public sealed class Course : Base.BaseEntity<int>
    {

        [Column("CourseID")]
        [Key]
        public override int Id { get; set; }
    }
}

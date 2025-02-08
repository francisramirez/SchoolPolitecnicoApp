

using SchoolPoliApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPoliApp.Domain.Entities;

public sealed class Student : Person<int>
{

    [Key]
    [Column("Id")]
    public override int Id { get; set; }


    public DateTime? EnrollmentDate { get; set; }


}
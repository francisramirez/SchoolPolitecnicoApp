

namespace SchoolPoliApp.Domain.Entities;

public partial class Student
{
    public int Id { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public DateTime? EnrollmentDate { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int CreationUser { get; set; }

    public int? UserMod { get; set; }

    public int? UserDeleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public bool Deleted { get; set; }
}
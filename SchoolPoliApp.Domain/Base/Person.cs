

namespace SchoolPoliApp.Domain.Base
{
    public abstract class Person<Type> : BaseEntity<Type>
    {
        public string? LastName { get; set; }

        public string? FirstName { get; set; }
    }
}

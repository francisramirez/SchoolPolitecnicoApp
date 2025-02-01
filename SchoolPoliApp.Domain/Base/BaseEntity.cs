

namespace SchoolPoliApp.Domain.Base
{
    public abstract class BaseEntity<Ttype> : AuditEntity
    {
        public abstract Ttype Id { get; set; }
    }
}

﻿
namespace SchoolPoliApp.Domain.Base
{
    public abstract class AuditEntity
    {
        protected AuditEntity()
        {
            this.CreationDate = DateTime.Now;
            this.Deleted = false;
        }
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? UserMod { get; set; }
        public int? UserDeleted { get; set; }
        public bool? Deleted { get; set; }
    }
}

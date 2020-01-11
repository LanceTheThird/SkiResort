using Data.Entities.Base;
using Data.Entities.Roles;

namespace Data.Entities.Users
{
    public class Account : EntityWithState
    {
        public virtual string Login { get; set; }
        public virtual Role Role { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Address { get; set; }
    }
}

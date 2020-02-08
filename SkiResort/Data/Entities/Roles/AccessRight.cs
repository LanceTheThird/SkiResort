using Data.Entities.Base;
using Data.Enum;

namespace Data.Entities.Roles
{
    public class AccessRight : EntityWithName
    {
        public virtual AccessTypeEnum AccessType { get; set; }
        public virtual AccessObjectEnum AccessObject { get; set; }
    }
}

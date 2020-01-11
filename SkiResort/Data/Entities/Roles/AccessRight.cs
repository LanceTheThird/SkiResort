using Data.Entities.Base;
using Data.Enum;

namespace Data.Entities.Roles
{
    public class AccessRight : EntityBase
    {
        public virtual AccessTypeEnum AccessType { get; set; }
        public virtual AccessObjectEnum AccessObject { get; set; }
    }
}

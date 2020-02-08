using Data.Entities.Base;
using System.Collections.Generic;

namespace Data.Entities.Roles
{
    public class Role : EntityWithName
    {
        public virtual string Title { get; set; }
        public virtual IList<AccessRight> AccessRightList { get; set; }
    }
}

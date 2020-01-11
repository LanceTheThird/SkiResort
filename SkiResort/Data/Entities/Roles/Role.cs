using Data.Entities.Base;
using System.Collections.Generic;

namespace Data.Entities.Roles
{
    public class Role : EntityWithState
    {
        public virtual string Title { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<AccessRight> AccessRightList { get; set; }
    }
}

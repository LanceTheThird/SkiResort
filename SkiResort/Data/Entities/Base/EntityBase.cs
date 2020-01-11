using System;

namespace Data.Entities.Base
{
    public class EntityBase
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime CreatedOn { get; set; }
    }
}

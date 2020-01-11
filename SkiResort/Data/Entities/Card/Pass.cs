
using Data.Entities.Base;
using Data.Entities.Turnstiles;
using System.Collections.Generic;

namespace Data.Entities.Card
{
    public class Pass : EntityWithState
    {
        public virtual ICollection<Turnstile> Turnstiles { get; set; }
    }
}

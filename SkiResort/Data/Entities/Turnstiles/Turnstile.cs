using Data.Entities.Base;
using Data.Entities.Card;
using System.Collections.Generic;

namespace Data.Entities.Turnstiles
{
    public class Turnstile : EntityWithState
    {
        public virtual ICollection<Pass> Passes { get; set; }
        public virtual int TimeDelayToPassAgain { get; set; }
    }
}

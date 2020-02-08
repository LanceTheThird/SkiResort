using Data.Entities.Base;
using Data.Entities.Card;
using System.Collections.Generic;

namespace Data.Entities.Turnstiles
{
    public class Turnstile : EntityWithName
    {
        public virtual IList<PassTurnstile> PassTurnstiles { get; set; }
        public virtual int TimeDelayToPassAgain { get; set; }
    }
}

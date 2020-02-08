using Data.Entities.Base;
using Data.Entities.Turnstiles;
using Data.Entities.Users;
using System;

namespace Data.Entities.Card
{
    public class Card : EntityWithName
    {
        public virtual Pass Pass { get; set; }
        public virtual User User { get; set; }
        public virtual Turnstile LastPassedGate { get; set; }
        public virtual DateTime LastPassedDate { get; set; }
        public virtual DateTime NextPassingDate { get; set; }
    }
}

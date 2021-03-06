﻿using Data.Entities.Base;
using Data.Entities.Turnstiles;
using System;
using System.Collections.Generic;

namespace Data.Entities.Card
{
    public class Pass : EntityWithName
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public virtual IList<PassTurnstile> PassTurnstiles { get; set; }
    }

    public class PassTurnstile
    {
        public Guid PassId { get; set; }
        public Guid TurnstileId { get; set; }
        public Pass Pass { get; set; }
        public Turnstile Turnstile { get; set; }


    }
}

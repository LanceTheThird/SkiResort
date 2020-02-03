using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turnstile.Models
{
    public class TurnstileRequest
    {
        public Guid CardId { get; set; }
        public Guid TurnstileId { get; set; }
    }
}

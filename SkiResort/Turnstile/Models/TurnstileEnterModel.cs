using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turnstile.Models
{
    public class TurnstileEnterModel
    {
        public TurnstileEnterModel()
        {
            IsMayEnter = true;
        }

        public TurnstileEnterModel(string message)
        {
            IsMayEnter = false;
            Message = message;
        }
        public bool IsMayEnter { get; set; }
        public string Message { get; set; }
    }
}

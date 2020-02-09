using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.ViewModels
{
    public class PassTurnstileViewModel
    {
        public string TurnstileName { get; set; }
        public bool IsInPass { get; set; }
        public Guid PassId { get; set; }
        public Guid TurnstileId { get; set; }
    }
}

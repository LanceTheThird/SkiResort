using Data.Entities.Card;
using Data.Entities.Turnstiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.ViewModels.Mappers
{
    public static class PassTurnstileViewModelMapper
    {
        public static PassTurnstileViewModel Map(Turnstile source, Pass pass, PassTurnstileViewModel destination)
        {
            destination.TurnstileName = source.Name;
            destination.TurnstileId = source.Id;
            destination.PassId = pass.Id;
            return destination;
        }
    }
}

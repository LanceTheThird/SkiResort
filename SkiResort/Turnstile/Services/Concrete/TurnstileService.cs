using Turnstile.Models;
using Turnstile.Services.Abstract;

namespace Turnstile.Services.Concrete
{
    public class TurnstileService : ITurnstileService
    {
        public TurnstileEnterModel Enter(string data)
        {
            return new TurnstileEnterModel();
        }
    }
}

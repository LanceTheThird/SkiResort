using Turnstile.Models;

namespace Turnstile.Services.Abstract
{
    public interface ITurnstileService
    {
        public TurnstileEnterModel Enter(TurnstileRequest data);
    }
}

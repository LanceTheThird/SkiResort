using Data.Entities.Turnstiles;
using Data.Context;

namespace Data.Repository.Concrete
{
    public class TurnstileRepository : EntityRepository<Turnstile>
    {
        public TurnstileRepository(TurnstileContext repositoryContext) : base(repositoryContext)
        { }
    }
}

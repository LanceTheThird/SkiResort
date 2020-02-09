using Data.Context;
using Data.Entities.Card;
using System;

namespace Data.Repository.Concrete
{
    public class PassTurnstileRepository : EntityRepository<PassTurnstile>
    {
        public PassTurnstileRepository(TurnstileContext repositoryContext) : base(repositoryContext)
        { }
    }
}
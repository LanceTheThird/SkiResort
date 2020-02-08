using Data.Context;
using Data.Entities.Card;
using System;

namespace Data.Repository.Concrete
{
    public class PassRepository : EntityRepository<Pass>
    {
        public PassRepository(TurnstileContext repositoryContext) : base(repositoryContext)
        { }

        public override void Create(Pass pass)
        {
            pass.Id = Guid.NewGuid();
            pass.CreatedOn = DateTime.Now;
            this.TurnstileContext.Passes.Add(pass);
            this.TurnstileContext.SaveChanges();
        }

        public override void Update(Pass pass)
        {
            this.TurnstileContext.Passes.Update(pass);
            this.TurnstileContext.SaveChanges();
        }

        public override void Delete(Pass pass)
        {
            this.TurnstileContext.Passes.Remove(pass);
            this.TurnstileContext.SaveChanges();
        }
    }
}

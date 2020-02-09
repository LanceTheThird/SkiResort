using Data.Context;
using Data.Entities.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository.Concrete
{
    public class CardRepository : EntityRepository<Card>
    {
        public CardRepository(TurnstileContext repositoryContext) : base(repositoryContext)
        { }

        public override void Create(Card Card)
        {
            Card.Id = Guid.NewGuid();
            Card.CreatedOn = DateTime.Now;
            this.TurnstileContext.Cards.Add(Card);
            this.TurnstileContext.SaveChanges();
        }

        public override void Update(Card Card)
        {
            this.TurnstileContext.Cards.Update(Card);
            this.TurnstileContext.SaveChanges();
        }

        public override void Delete(Card Card)
        {
            this.TurnstileContext.Cards.Remove(Card);
            this.TurnstileContext.SaveChanges();
        }
    }
}
using Data.Entities.Card;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Admin.Services.Abstract
{
    public interface ICardService
    {
        IQueryable<Card> GetAll();
        void Create(Card entity);
        void Update(Card entity);
        void Delete(Card entity);
        IQueryable<Card> GetByCondition(Expression<Func<Card, bool>> expression);
    }
}

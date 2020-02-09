using Admin.Services.Abstract;
using Data.Entities.Card;
using Data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Admin.Services.Concrete
{
    public class CardService : ICardService
    {
        private IResortRepository<Card> _CardRepository;
        public CardService(IResortRepository<Card> CardRepository)
        {
            _CardRepository = CardRepository;
        }

        public IQueryable<Card> GetAll()
        {
            return _CardRepository.GetAll();
        }
        public void Create(Card entity)
        {
            _CardRepository.Create(entity);
        }
        public void Update(Card entity)
        {
            _CardRepository.Update(entity);
        }
        public void Delete(Card entity)
        {
            _CardRepository.Delete(entity);
        }
        public IQueryable<Card> GetByCondition(Expression<Func<Card, bool>> expression)
        {
            return _CardRepository.GetByCondition(expression);
        }
    }
}

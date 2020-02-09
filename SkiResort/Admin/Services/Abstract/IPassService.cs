using Data.Entities.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Admin.ViewModels;

namespace Admin.Services.Abstract
{
    public interface IPassService
    {
        IQueryable<Pass> GetAll();
        void Create(Pass entity);
        void Update(Pass entity);
        void Delete(Pass entity);
        IQueryable<Pass> GetByCondition(Expression<Func<Pass, bool>> expression);
        IEnumerable<PassTurnstileViewModel> GetTurnstiles(Guid Id);
        void AddTurnstile(Guid passId, Guid turnstileId);
        void RemoveTurnstile(Guid passId, Guid turnstileId);
    }
}

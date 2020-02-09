using Admin.Services.Abstract;
using Admin.ViewModels;
using Admin.ViewModels.Mappers;
using Data.Entities.Card;
using Data.Entities.Turnstiles;
using Data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Admin.Services.Concrete
{
    public class PassService : IPassService
    {
        private IResortRepository<Pass> _passRepository;
        private IResortRepository<Turnstile> _turnstileRepository;
        private IResortRepository<PassTurnstile> _connRepository;
        public PassService(IResortRepository<Pass> passRepository, IResortRepository<Turnstile> turnstileRepository, IResortRepository<PassTurnstile> connRepository)
        {
            _passRepository = passRepository;
            _turnstileRepository = turnstileRepository;
            _connRepository = connRepository;
        }

        public IQueryable<Pass> GetAll()
        {
            return _passRepository.GetAll();
        }
        public void Create(Pass entity)
        {
            _passRepository.Create(entity);
        }
        public void Update(Pass entity)
        {
            _passRepository.Update(entity);
        }
        public void Delete(Pass entity)
        {
            _passRepository.Delete(entity);
        }
        public IQueryable<Pass> GetByCondition(Expression<Func<Pass, bool>> expression)
        {
            return _passRepository.GetByCondition(expression);
        }
        public IEnumerable<PassTurnstileViewModel> GetTurnstiles(Guid Id)
        {
            var pass  = GetByCondition(x => x.Id == Id).FirstOrDefault();
            var result = new List<PassTurnstileViewModel>();
            var turnstiles = _turnstileRepository.GetAll();
            foreach (var stile in turnstiles)
            {
                var model = new PassTurnstileViewModel();
                if (pass.PassTurnstiles != null)
                {
                    foreach (var conn in pass.PassTurnstiles)
                    {
                        if (stile.Id == conn.TurnstileId)
                        {
                            model.IsInPass = true;
                            break;
                        }
                    }
                }
                result.Add(PassTurnstileViewModelMapper.Map(stile, pass, model));

            }
           
            return result;

        }

        public void AddTurnstile(Guid passId, Guid turnstileId)
        {

        }
        public void RemoveTurnstile(Guid passId, Guid turnstileId)
        {

        }
    }
}

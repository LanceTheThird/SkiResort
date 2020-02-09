using Admin.Services.Abstract;
using Data.Entities.Users;
using Data.Repository.Abstract;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Admin.Services.Concrete
{
    public class UserService : IUserService
    {
        private IResortRepository<User> _UserRepository;
        public UserService(IResortRepository<User> UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public IQueryable<User> GetAll()
        {
            return _UserRepository.GetAll();
        }
        public void Create(User entity)
        {
            _UserRepository.Create(entity);
        }
        public void Update(User entity)
        {
            _UserRepository.Update(entity);
        }
        public void Delete(User entity)
        {
            _UserRepository.Delete(entity);
        }
        public IQueryable<User> GetByCondition(Expression<Func<User, bool>> expression)
        {
            return _UserRepository.GetByCondition(expression);
        }
    }
}
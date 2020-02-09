using Data.Entities.Users;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Admin.Services.Abstract
{
    public interface IUserService
    {
        IQueryable<User> GetAll();
        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);
        IQueryable<User> GetByCondition(Expression<Func<User, bool>> expression);
    }
}

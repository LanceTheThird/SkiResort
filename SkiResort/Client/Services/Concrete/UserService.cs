using Client.Services.Abstract;
using Data.Entities.Users;
using Data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Services.Concrete
{
    public class UserService : IUserService
    {
        private IResortRepository<User> _repository;

        public UserService(IResortRepository<User> repository)
        {
            _repository = repository;
        }

        public User FindByLogin(string login)
        {
            return _repository.GetByCondition(x => x.Login == login).FirstOrDefault();
        }
        public bool CheckPassword(User user, string password)
        {
            return (user.Password == password);
        }
    }
}

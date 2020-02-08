using Data.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Services.Abstract
{
    public interface IUserService
    {
        public User FindByLogin(string login);
        public bool CheckPassword(User user, string password);
    }
}

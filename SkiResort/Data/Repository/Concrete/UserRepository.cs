using Data.Context;
using Data.Entities.Users;

namespace Data.Repository.Concrete
{
    public class UserRepository : EntityRepository<User>
    {
        public UserRepository(TurnstileContext repositoryContext) : base(repositoryContext)
        { }
    }
}

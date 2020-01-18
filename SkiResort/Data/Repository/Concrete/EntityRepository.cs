using Data.Context;
using Data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository.Concrete
{
    public class EntityRepository<T> : RepositoryBase<T> where T : class
    {
        public EntityRepository(TurnstileContext repositoryContext) : base(repositoryContext)
        { }
    }
}

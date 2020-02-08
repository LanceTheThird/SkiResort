using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data.Repository.Abstract
{
    public abstract class RepositoryBase<T> : IResortRepository<T> where T : class
    {
        protected TurnstileContext TurnstileContext { get; set; }

        public RepositoryBase(TurnstileContext repositoryContext)
        {
            this.TurnstileContext = repositoryContext;
        }

        public IQueryable<T> GetAll()
        {
            return this.TurnstileContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return this.TurnstileContext.Set<T>().Where(expression).AsNoTracking();
        }

        public virtual void Create(T entity)
        {
            this.TurnstileContext.Set<T>().Add(entity);
        }

        public virtual void Update(T entity)
        {
            this.TurnstileContext.Set<T>().Update(entity);
        }

        public virtual void Delete(T entity)
        {
            this.TurnstileContext.Set<T>().Remove(entity);
        }
    }
}

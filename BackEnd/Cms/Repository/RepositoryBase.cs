using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRepository;
using EntityDB;
using System.Linq.Expressions;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _RepositoryContext { get; set; }
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this._RepositoryContext = repositoryContext;
        }
        public IEnumerable<T> FindAll()
        {
            return this._RepositoryContext.Set<T>();
        }
        public  IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return  this._RepositoryContext.Set<T>().Where(expression);
        }
        public void Create(T entity)
        {
            this._RepositoryContext.Set<T>().Add(entity);
        }
        public void Update(T Dbentity, T entity)
        {
            this._RepositoryContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this._RepositoryContext.Set<T>().Remove(entity);
        }
        public  void save()
        {
            this._RepositoryContext.SaveChanges();

        }
    }


}

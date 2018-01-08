using SinemaOtoSis.Core.Databases.RepositoryBase.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SinemaOtoSis.Core.Databases.RepositoryBase.Concrete
{
    public abstract class RepositoryBase<T, TContext> : IRepositoryBase<T>, IDisposable
        where T : class, new()
        where TContext : DbContext
    {
        protected DbContext _dbContext;
        protected IDbSet<T> _dbSet;
        protected bool _disposed = false;

        public RepositoryBase(DbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T Entity)
        {
            _dbSet.Add(Entity);
            _dbContext.SaveChanges();
            
        }

        public void Delete(int Id)
        {
            var sonuc = _dbSet.Find(Id);
            _dbSet.Remove(sonuc);
            _dbContext.SaveChanges();
           
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_disposed == false)
                {
                    Dispose();
                    _disposed = true;
                }
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public T GetFindById(int Id)
        {
            return _dbSet.Find(Id);
        }



        public void Update(T Entity, int id)
        {
            
            var ent = _dbSet.Find(id);
            _dbContext.Entry(ent).CurrentValues.SetValues(Entity);
            _dbContext.SaveChanges();
            
           
        }
        public IEnumerable<T> GetList(Expression<Func<T, bool>> predicate = null)
        {

            if (predicate == null)
            {
                return _dbSet.ToList();
            }
            return _dbSet.Where(predicate).ToList();

        }

        public IQueryable<T> GetByFilter(Expression<Func<T, bool>> lambda)
        {
            return _dbSet.Where(lambda).AsQueryable<T>();
        }
    }
    
   
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtoSis.Core.Databases.RepositoryBase.Abstract
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        void Add(T Entity);
        void Update(T Entity,int id);
        void Delete(int Id);
        T GetFindById(int Id);
        IEnumerable<T> GetList(Expression<Func<T, bool>> predicate= null);

        IQueryable<T> GetByFilter(Expression<Func<T, bool>> lambda);
        


    }
}

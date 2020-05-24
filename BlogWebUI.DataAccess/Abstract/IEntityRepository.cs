using BlogWebUI.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebUI.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    where T:class,IDatabaseEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}

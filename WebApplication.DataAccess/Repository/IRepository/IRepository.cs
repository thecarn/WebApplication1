using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.DataAccess.Repository.IRepository
{
    //typically, when we are working with generic interface where we do not know what the class type
    //will be we say it will be a generic type <T> ......
    internal interface IRepository<T> where T : class
    {
        //T - Category
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        
        //update usually has specific scenario implementations thus can be overrided in location of use
        //void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        
    }
}

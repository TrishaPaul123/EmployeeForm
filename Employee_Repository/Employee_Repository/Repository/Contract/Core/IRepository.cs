using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Repository.Repository.Contract.Core
{
    public interface IRepository<T> where T : class
    {      
            void Add(T entity);
            void Modify(T entity);
            void Remove(T entity);
            IEnumerable<T> Find(Func<T, bool> predicate);
            IEnumerable<T> GetAll();        
    }
}

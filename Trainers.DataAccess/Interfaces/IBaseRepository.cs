using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers.DataAccess.Interfaces
{
    public interface IBaseRepository<T>
    {
        T Get(int id);
        IQueryable<T> Get();
        IQueryable<T> Get(Func<T, bool> exp);
        void Save(T obj);
        void Delete(T obj);
    }
}

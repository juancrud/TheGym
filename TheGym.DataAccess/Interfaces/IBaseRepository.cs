using System;
using System.Linq;

namespace TheGym.DataAccess.Interfaces
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

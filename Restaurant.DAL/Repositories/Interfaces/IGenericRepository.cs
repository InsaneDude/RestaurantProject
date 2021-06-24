using System.Collections.Generic;

namespace Restaurant.DAL.Interfaces
{
    public interface IGenericRepository<T, K>
    {
        void Add(T ent);
        void Update(T ent);
        T Get(K id);
        void Delete(K id);
        List<T> GetAll();
    }
}
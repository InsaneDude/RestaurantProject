using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class GenericRepository<T, K> : IGenericRepository<T, K> where T : BaseEntity<K>
    {
        private readonly RestaurantDBContext context;
        // private readonly DbSet<T> table = null;

        public GenericRepository(RestaurantDBContext context)
        {
            // table = context.Set<T>();
            this.context = context;
        }
        
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(K id)
        {
            context.Set<T>().Remove(Get(id));
        }

        public T Get(K id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            // старое
            // T find = Get(entity.Id);
            // context.Entry(find).CurrentValues.SetValues(entity);

            // context.Entry(entity).State = EntityState.Modified;
            // context.SaveChanges();
        }
        
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
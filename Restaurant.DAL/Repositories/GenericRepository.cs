using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class GenericRepository<T, K> : IGenericRepository<T, K> where T : BaseEntity<K>
    {
        private readonly RestaurantDBContext _context;

        public GenericRepository(RestaurantDBContext context)
        {
            _context = context;
        }
        
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(K id)
        {
            _context.Set<T>().Remove(Get(id));
        }

        public T Get(K id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            T find = Get(entity.Id);
            _context.Entry(find).State = EntityState.Modified;
            _context.SaveChanges();
        }
        
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using ProductAPI.DAL.Abstract;
using System.Linq;

namespace ProductAPI.DAL.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private AuthorsDbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(AuthorsDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Delete(T item)
        {
            if (_context.Entry(item).State == EntityState.Detached)
            {
                _dbSet.Attach(item);
            }
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            T item = _context.Set<T>().Find(id);
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Insert(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
            return item;
        }

        public T Update(T item)
        {
            _dbSet.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;

        }
    }
}

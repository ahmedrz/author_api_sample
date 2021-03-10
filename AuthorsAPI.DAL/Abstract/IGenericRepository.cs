using System.Linq;

namespace ProductAPI.DAL.Abstract
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        T Insert(T item);
        T Update(T item);
        void Delete(T item);
        void Delete(int id);


    }
}

using System.Linq.Expressions;
using DataAccess.Domain;

namespace DataAccess.Repository
{
    public interface IRanRepository<T> where T : BaseDomain
    {
        T GetById(int id);
        
        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        void Update(T Entity);
    }
}
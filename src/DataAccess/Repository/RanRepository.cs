using System.Linq.Expressions;
using RanApp.DataAccess.Domain;

namespace RanApp.DataAccess.Repository
{
    public class RanRepository<T> : IRanRepository<T> where T : BaseDomain
    {
        private readonly RanDbContext dbContext;

        public RanRepository(RanDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(T entity)
        {
            this.dbContext.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            this.dbContext.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return this.dbContext.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return this.dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return this.dbContext.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            this.dbContext.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            this.dbContext.Set<T>().RemoveRange(entities);
        }

        public void Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
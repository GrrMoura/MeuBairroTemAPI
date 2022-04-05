using AcheFacilAPi.Domain.Entities;
using System.Linq.Expressions;

namespace AcheFacilAPi.Domain.Repositories
{
    public interface IRepository<TEntity>:IDisposable where TEntity : Entity
    {
        Task Add(TEntity entity);
        Task  Update(TEntity entity);
        Task Delete(Guid id);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();

    }
}

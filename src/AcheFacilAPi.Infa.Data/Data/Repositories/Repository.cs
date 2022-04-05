using AcheFacilAPi.Domain.Entities;
using AcheFacilAPi.Domain.Repositories;
using AcheFacilAPi.Infa.Data.DbApplications;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AcheFacilAPi.Infa.Data.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity,new()
    {
        public readonly DbApplication? _db ;
        private readonly DbSet<TEntity>? _dbSet;

        public Repository(DbApplication? db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }
        public virtual async Task  Add(TEntity entity)
        {
            _db?.Add(entity);
            await SaveChanges();
        }


        public async Task Update(TEntity entity)
        {
            _db.Entry<TEntity>(entity).State = EntityState.Modified;
            await SaveChanges();

        }

        public async Task Delete(Guid id)
        {
            _db.Entry(new TEntity{Id =id}).State = EntityState.Deleted;
            await SaveChanges();
        }

        
        public async Task<List<TEntity>> GetAll()
        {
          return await _dbSet!.ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
           return await _dbSet.FindAsync(id);
        }

        public async Task<int> SaveChanges()
        {
           return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }
        public void Dispose()
        {
           _db?.Dispose();
        }

    }
}

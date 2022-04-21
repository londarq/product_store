using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        
        protected readonly ApplicationContext.ApplicationContext DbContext;
        
        public GenericRepository(ApplicationContext.ApplicationContext dbContext)
        {
            DbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbContext.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllEntitiesAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await DbContext.AddAsync(entity);
            await DbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            DbContext.Update(entity);
            await DbContext.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            DbContext.Remove(entity);
            await DbContext.SaveChangesAsync();
        }
    }
}

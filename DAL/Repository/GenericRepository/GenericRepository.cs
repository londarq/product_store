using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        
        protected readonly ApplicationContext.ApplicationContext db;
        
        public GenericRepository(ApplicationContext.ApplicationContext _db)
        {
            db = _db;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await db.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await db.Set<TEntity>().Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await db.Set<TEntity>().AddAsync(entity);
            await db.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
            await db.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await db.Set<TEntity>().FindAsync(id);
            db.Set<TEntity>().Remove(entity);
            await db.SaveChangesAsync();

            return true;
        }
    }
}

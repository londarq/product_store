using DAL.Entities;
using DAL.Repository.GenericRepository;
using DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductInventoryRepository : GenericRepository<ProductInventory>, IProductInventoryRepository
    {
        public ProductInventoryRepository(ApplicationContext.ApplicationContext dbContext) : base(dbContext) {}

        public Task<ProductInventory> GetProductInventoryByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

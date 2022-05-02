using DAL.Entities;
using DAL.Repository.GenericRepository;
using DAL.Interfaces;
using DAL.Context;

namespace DAL.Repository
{
    public class InventoryRepository : GenericRepository<ProductInventory>, IInventoryRepository
    {
        public InventoryRepository(ApplicationDbContext dbContext) : base(dbContext) {}
    }
}

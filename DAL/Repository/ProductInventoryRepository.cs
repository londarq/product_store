using DAL.Entities;
using DAL.Repository.GenericRepository;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DAL.Context;

namespace DAL.Repository
{
    public class ProductInventoryRepository : GenericRepository<ProductInventory>, IProductInventoryRepository
    {
        public ProductInventoryRepository(ApplicationDbContext dbContext) : base(dbContext) {}
    }
}

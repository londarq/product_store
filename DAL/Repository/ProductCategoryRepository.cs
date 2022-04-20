using DAL.Entities;
using DAL.Repository.GenericRepository;
using DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ApplicationContext.ApplicationContext dbContext) : base(dbContext) {}

        public Task<ProductCategory> GetProductCategoryByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

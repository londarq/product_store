using DAL.Entities;
using DAL.Repository.GenericRepository;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ApplicationContext.ApplicationContext dbContext) : base(dbContext) {}
    }
}

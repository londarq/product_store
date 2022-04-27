using DAL.Entities;
using DAL.Repository.GenericRepository;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DAL.Context;

namespace DAL.Repository
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ApplicationDbContext dbContext) : base(dbContext) {}
    }
}

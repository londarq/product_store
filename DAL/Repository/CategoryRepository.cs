using DAL.Entities;
using DAL.Repository.GenericRepository;
using DAL.Interfaces;
using DAL.Context;

namespace DAL.Repository
{
    public class CategoryRepository : GenericRepository<ProductCategory>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext) {}
    }
}

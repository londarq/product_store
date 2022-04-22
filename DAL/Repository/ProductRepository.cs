using DAL.Entities;
using DAL.Interfaces;
using DAL.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext.ApplicationContext dbContext) : base(dbContext) {}

        //??????????????? сделать этот репозиторий основным для взаимодействия c бд
        //
        //public IEnumerable<Product> GetProductsByCategory(string category)
        //{
        //    return _ctx.Products
        //               .Where(p => p.Category == category)
        //               .ToList();
        //}
        //??????????????? ещё, напр, метод GetBestSellingProducts
    }
}

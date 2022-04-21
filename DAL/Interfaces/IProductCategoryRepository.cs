using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductCategoryRepository : IGenericRepository<ProductCategory>
    {
        public Task<ProductCategory> GetProductCategoryByIdAsync(int id);
    }
}

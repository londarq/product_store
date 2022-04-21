using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IProductCategoryRepository : IGenericRepository<ProductCategory>
    {
        public Task<ProductCategory> GetProductCategoryByIdAsync(int id);
    }
}

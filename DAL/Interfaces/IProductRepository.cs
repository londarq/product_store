using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<Product> GetProductByIdAsync(int id);
    }
}

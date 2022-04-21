using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<Product> GetProductByIdAsync(int id);
    }
}

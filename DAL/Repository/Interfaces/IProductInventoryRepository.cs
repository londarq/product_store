using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IProductInventoryRepository
    {
        public Task<ProductInventory> GetProductInventoryByIdAsync(int id);
    }
}

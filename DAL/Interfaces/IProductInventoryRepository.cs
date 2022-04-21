using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductInventoryRepository
    {
        public Task<ProductInventory> GetProductInventoryByIdAsync(int id);
    }
}

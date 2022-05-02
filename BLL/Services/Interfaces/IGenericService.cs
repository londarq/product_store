using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IGenericService<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(int id);
        Task<TModel> CreateAsync(TModel dto);
        Task<TModel> UpdateAsync(TModel dto);
        Task<bool> DeleteAsync(int id);
    }
}

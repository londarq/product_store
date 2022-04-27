using BLL.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IGenericService<Tdto> where Tdto : BaseDTO
    {
        Task<IEnumerable<Tdto>> GetAllAsync();
        Task<Tdto> GetByIdAsync(int id);
        Task<Tdto> CreateAsync(Tdto dto);
        Task<Tdto> UpdateAsync(Tdto dto);
        Task<bool> DeleteAsync(int id);
    }
}

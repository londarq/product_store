using AutoMapper;
using BLL.Domain;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public abstract class GenericService<TRepository, Tdto, TEntity> : IGenericService<Tdto> where Tdto : BaseDTO
        where TRepository : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly IGenericRepository<TEntity> repo;
        private readonly IMapper mapper;

        public GenericService(TRepository _repo, IMapper _mapper)
        {
            repo = _repo;
            mapper = _mapper;
        }

        public async Task<IEnumerable<Tdto>> GetAllAsync()
        {
            var entities = await repo.GetAllAsync();

            return mapper.Map<IEnumerable<Tdto>>(entities);
        }

        public async Task<Tdto> GetByIdAsync(int id)
        {
            var entity = await repo.GetByIdAsync(id);

            return mapper.Map<Tdto>(entity);
        }

        public async Task<Tdto> CreateAsync(Tdto dto)
        {
            var entity = mapper.Map<TEntity>(dto);
            var result = await repo.CreateAsync(entity);

            return mapper.Map<Tdto>(result);
        }

        public async Task<Tdto> UpdateAsync(Tdto dto)
        {
            var entity = mapper.Map<TEntity>(dto);
            var result = await repo.UpdateAsync(entity);

            return mapper.Map<Tdto>(result);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var isDeleted = await repo.DeleteAsync(id);

            return isDeleted;
        }
    }
}

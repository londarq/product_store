using AutoMapper;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public abstract class GenericService<TRepository, TModel, TEntity> : IGenericService<TModel> where TModel : class
        where TRepository : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly IGenericRepository<TEntity> repo;
        private readonly IMapper mapper;

        public GenericService(TRepository _repo, IMapper _mapper)
        {
            repo = _repo;
            mapper = _mapper;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var entities = await repo.GetAllAsync();

            return mapper.Map<IEnumerable<TModel>>(entities);
        }

        public async Task<TModel> GetByIdAsync(int id)
        {
            var entity = await repo.GetByIdAsync(id);

            return mapper.Map<TModel>(entity);
        }

        public async Task<TModel> CreateAsync(TModel model)
        {
            var entity = mapper.Map<TEntity>(model);
            var result = await repo.CreateAsync(entity);

            return mapper.Map<TModel>(result);
        }

        public async Task<TModel> UpdateAsync(TModel model)
        {
            var entity = mapper.Map<TEntity>(model);
            var result = await repo.UpdateAsync(entity);

            return mapper.Map<TModel>(result);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var isDeleted = await repo.DeleteAsync(id);

            return isDeleted;
        }
    }
}

using AutoMapper;
using BLL.Domain;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class ProductCategoryService : GenericService<IProductCategoryRepository, ProductCategoryDTO, ProductCategory>, IProductCategoryService
    {
        public ProductCategoryService(IProductCategoryRepository _repo, IMapper _mapper) : base(_repo, _mapper) { }
    }
}

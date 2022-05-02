using AutoMapper;
using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class CategoryService : GenericService<ICategoryRepository, CategoryModel, ProductCategory>, ICategoryService
    {
        public CategoryService(ICategoryRepository _repo, IMapper _mapper) : base(_repo, _mapper) { }
    }
}

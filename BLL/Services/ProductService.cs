using AutoMapper;
using BLL.Domain;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class ProductService : GenericService<IProductRepository, ProductDTO, Product>, IProductService
    {
        public ProductService(IProductRepository _repo, IMapper _mapper) : base(_repo, _mapper) {}
    }
}

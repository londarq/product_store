using AutoMapper;
using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class ProductService : GenericService<IProductRepository, ProductModel, Product>, IProductService
    {
        public ProductService(IProductRepository _repo, IMapper _mapper) : base(_repo, _mapper) {}
    }
}

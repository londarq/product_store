using AutoMapper;
using BLL.Models;
using DAL.Entities;

namespace BLL.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<ProductCategory, CategoryModel>().ReverseMap();
            CreateMap<ProductInventory, InventoryModel>().ReverseMap();
        }
    }
}

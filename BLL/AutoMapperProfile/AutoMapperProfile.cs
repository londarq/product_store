using AutoMapper;
using BLL.Domain;
using DAL.Entities;

namespace BLL.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BaseEntity, BaseDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryDTO>().ReverseMap();
            CreateMap<ProductInventory, ProductInventoryDTO>().ReverseMap();
        }
    }
}

using AutoMapper;
using API.Models;
using BLL.Domain;

namespace API.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BaseDTO, BaseModel>().ReverseMap();
            CreateMap<ProductDTO, ProductModel>().ReverseMap();
            CreateMap<ProductCategoryDTO, ProductCategoryModel>().ReverseMap();
            CreateMap<ProductInventoryDTO, ProductInventoryModel>().ReverseMap();
        }
    }
}

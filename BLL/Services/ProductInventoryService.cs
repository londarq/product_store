using AutoMapper;
using BLL.Domain;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class ProductInventoryService : GenericService<IProductInventoryRepository, ProductInventoryDTO, ProductInventory>, IProductInventoryService
    {
        public ProductInventoryService(IProductInventoryRepository _repo, IMapper _mapper) : base(_repo, _mapper) { }
    }
}

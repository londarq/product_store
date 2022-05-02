using AutoMapper;
using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class InventoryService : GenericService<IInventoryRepository, InventoryModel, ProductInventory>, IInventoryService
    {
        public InventoryService(IInventoryRepository _repo, IMapper _mapper) : base(_repo, _mapper) { }
    }
}

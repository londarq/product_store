namespace BLL.Domain
{
    public class ProductInventoryDTO : BaseDTO
    {
        public int Quantity { get; set; }

        public int? ProductId { get; set; }
        public ProductDTO? Product { get; set; }
    }
}

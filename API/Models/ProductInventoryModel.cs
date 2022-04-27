namespace API.Models
{
    public class ProductInventoryModel : BaseModel
    {
        public int Quantity { get; set; }

        public int? ProductId { get; set; }
        public ProductModel? Product { get; set; }
    }
}

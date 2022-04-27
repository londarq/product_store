namespace API.Models
{
    public class ProductModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int? CategoryId { get; set; }
        public ProductCategoryModel? Category { get; set; }
        public ProductInventoryModel? Inventory { get; set; }
    }
}

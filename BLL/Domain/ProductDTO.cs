namespace BLL.Domain
{
    public class ProductDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int? CategoryId { get; set; }
        public ProductCategoryDTO? Category { get; set; }
        public ProductInventoryDTO? Inventory { get; set; }
    }
}

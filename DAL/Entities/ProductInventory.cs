namespace DAL.Entities
{
    public class ProductInventory : BaseEntity
    {
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

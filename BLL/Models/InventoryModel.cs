﻿namespace BLL.Models
{
    public class InventoryModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int? ProductId { get; set; }
        public ProductModel? Product { get; set; }
    }
}

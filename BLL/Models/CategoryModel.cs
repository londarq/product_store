using System.Collections.Generic;

namespace BLL.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<ProductModel>? Products { get; set; }
    }
}

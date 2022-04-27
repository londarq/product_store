using System.Collections.Generic;

namespace API.Models
{
    public class ProductCategoryModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<ProductModel>? Products { get; set; }
    }
}

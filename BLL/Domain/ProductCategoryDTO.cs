using System.Collections.Generic;

namespace BLL.Domain
{
    public class ProductCategoryDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<ProductDTO>? Products { get; set; }
    }
}

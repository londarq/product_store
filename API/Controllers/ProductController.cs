using BLL.Models;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await productService.GetAllAsync();

            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await productService.GetByIdAsync(id);

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductModel newProduct)
        {
            var result = await productService.CreateAsync(newProduct);
            
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductModel productModel)
        {
            productModel.Id = id;
            var result = await productService.UpdateAsync(productModel);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await productService.DeleteAsync(id);

            return Ok(isDeleted);
        }
    }
}

using API.Models;
using AutoMapper;
using BLL.Domain;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;

        public ProductController(IProductService _productService, IMapper _mapper)
        {
            productService = _productService;
            mapper = _mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await productService.GetAllAsync();

            return Ok(mapper.Map<IEnumerable<ProductModel>>(posts));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await productService.GetByIdAsync(id);
            return Ok(mapper.Map<ProductModel>(product));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductModel newProduct)
        {
            var product = mapper.Map<ProductDTO>(newProduct);
            var result = await productService.CreateAsync(product);
            
            return Ok(mapper.Map<ProductModel>(result));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductModel productModel)
        {
            productModel.Id = id;
            var product = mapper.Map<ProductDTO>(productModel);
            var result = await productService.UpdateAsync(product);

            return Ok(mapper.Map<ProductModel>(result));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await productService.DeleteAsync(id);

            return Ok(isDeleted);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementBusiness.Services;
using ProductManagementDomain.Models;

namespace ProductManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            object result =await _productService.Add(product);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            object result =await _productService.Update(product);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            object result =await _productService.Delete(id);
            return Ok(result);
        }
        [HttpGet("products")]
        public async Task<IActionResult> GetAll()
        {
            object result = await _productService.GetAll();
            return Ok(result);
        }
        [HttpGet("products/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            object result = await _productService.GetById(id);
            return Ok(result);
        }
        [HttpGet("products/search")]
        public async Task<IActionResult> Search(string name)
        {
            object result = await _productService.GetByName(name);
            return Ok(result);
        }
        [HttpGet("products/total-count")]
        public async Task<IActionResult> TotalCount()
        {
            object result = await _productService.GetCount();
            return Ok(result);
        }
        [HttpGet("products/category/{category}")]
        public async Task<IActionResult> Category(string category)
        {
            object result = await _productService.GetProductByCategory(category);
            return Ok(result);
        }
    }
}

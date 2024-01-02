using Application.Dtos;
using Application.Services.Contracts;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomaticValidation.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("products")]
        public IActionResult GetAllProducts([FromQuery]int pageNumber = 1, [FromQuery]int pageSize = 5, [FromQuery]string? filter = null)
        {
            return Ok(_productService.GetAllProducts(pageNumber, pageSize, filter));
        }

        [HttpGet]
        [Route("products/{id}")]
        public IActionResult GetProductById([FromRoute]Guid id)
        {
            var product = _productService.GetProductById(id);

            if(product is null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        [Route("products")]
        public IActionResult CreateProduct([FromBody]ProductDto request)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Stock = request.Stock,
                Category = request.Category
            };

            _productService.AddProduct(product);

            return CreatedAtRoute(product.Id, product);
        }

        [HttpPut]
        [Route("products/{id}")]
        public IActionResult UpdateProduct([FromRoute]Guid id, [FromBody]ProductDto request)
        {
            var product = new Product
            {
                Id = id,
                Name = request.Name,
                Description = request.Description,
                Stock = request.Stock,
                Category = request.Category
            };

            _productService.UpdateProduct(id, product);

            return NoContent();
        }

        [HttpDelete]
        [Route("products/{id}")]
        public IActionResult DeleteProduct([FromRoute]Guid id)
        {
            _productService.DeleteProduct(id);

            return NoContent();
        }
    }
}

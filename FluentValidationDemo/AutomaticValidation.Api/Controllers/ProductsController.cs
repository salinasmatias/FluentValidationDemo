using Application.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomaticValidation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts([FromQuery]int pageNumber = 1, [FromQuery]int pageSize = 5, [FromQuery]string? filter = null)
        {
            return Ok(_productService.GetAllProducts(pageNumber, pageSize, filter));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Products_CleanArquitecture.Domain.Interfaces;

namespace Products_CleanArquitecture.Controller
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _repository.GetAllProducts();
            return Ok(products);
        }
    }
}

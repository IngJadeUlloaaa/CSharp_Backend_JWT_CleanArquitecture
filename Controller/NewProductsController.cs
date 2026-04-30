using Microsoft.AspNetCore.Mvc;
using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;

namespace Products_CleanArquitecture.Controller
{
    [ApiController]
    [Route("api/newproducts")]
    public class NewProductsController : ControllerBase
    {
        private readonly INewProductsRepository _newProductsRepository;

        public NewProductsController(INewProductsRepository newProductsRepository)
        {
            _newProductsRepository = newProductsRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewProduct([FromBody] Product product)
        {
            await _newProductsRepository.AddNewProductInterface(product);
            return Ok("Producto agregado");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;

namespace Products_CleanArquitecture.Controller
{
    [ApiController]
    [Route("api/editproducts")]
    public class EditProductsController : ControllerBase
    {
        private readonly IEdtProductsRepository _repository;

        public EditProductsController(IEdtProductsRepository repository)
        {
            _repository = repository;
        }

        [HttpPut]
        public async Task<IActionResult> EditProducts([FromBody] Product product)
        {
            await _repository.EditProductsById(product);
            return Ok("Producto actualizado");
        }
    }
}
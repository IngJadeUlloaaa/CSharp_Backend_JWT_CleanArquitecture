using Microsoft.AspNetCore.Mvc;
using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;

namespace Products_CleanArquitecture.Controller
{
    [ApiController]
    [Route("api/deleteProducts")]
    public class DeleteProductsController : ControllerBase
    {
        private readonly IDeleteProductsRepository _repository;

        public DeleteProductsController(IDeleteProductsRepository repository)
        {
            _repository = repository;
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProducts(int Id)
        {
            await _repository.DeleteProductsById(Id);
            return Ok("Producto eliminado");
        }
    }
}

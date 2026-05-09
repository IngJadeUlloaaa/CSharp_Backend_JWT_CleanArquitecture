using Products_CleanArquitecture.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Products_CleanArquitecture.Controller
{
    [ApiController]
    [Route("api/deleteCustomers")]
    public class DeleteCustomersController : ControllerBase
    {
        private readonly IDeleteCustomersRepository _repository;

        public DeleteCustomersController(IDeleteCustomersRepository repository)
        {
            _repository = repository;
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteCustomers(int Id)
        {
            await _repository.DeleteCustomersById(Id);
            return Ok("Cliente eliminado");
        }
    }
}

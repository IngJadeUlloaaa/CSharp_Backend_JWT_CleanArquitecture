using Microsoft.AspNetCore.Mvc;
using Products_CleanArquitecture.Domain.Interfaces;

namespace Products_CleanArquitecture.Controller
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController: ControllerBase
    {
        private readonly ICustomersRepository _repository;

        public CustomersController(ICustomersRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _repository.GetAllCustomers();
            return Ok(customers);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;

namespace Products_CleanArquitecture.Controller
{
    [ApiController]
    [Route("api/newCustomers")]
    public class NewCustomersController : ControllerBase
    {
        private readonly INewCustomersRepoistory _newCustomersRepository;

        public NewCustomersController(INewCustomersRepoistory newCustomersRepository)
        {
            _newCustomersRepository = newCustomersRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCustomers([FromBody] Customers customers)
        {
            await _newCustomersRepository.INewCustomers(customers);
            return Ok("Cliente Agregado");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;

namespace Products_CleanArquitecture.Controller
{
    [ApiController]
    [Route("api/editcustomers")]
    public class EditCustomersController : ControllerBase
    {
        private readonly IEditCustomers _editCustomers;

        public EditCustomersController(IEditCustomers editCustomers)
        {
            _editCustomers = editCustomers;
        }

        [HttpPut]
        public async Task<IActionResult> EditCustomersById([FromBody] Customers customers)
        {
            await _editCustomers.IEditCustomersById(customers);
            return Ok("Customer edited successfully");
        }
    }
}

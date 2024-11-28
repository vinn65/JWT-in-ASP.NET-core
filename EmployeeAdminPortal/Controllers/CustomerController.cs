using EmployeeAdminPortal.Interfaces;
using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(CustomerService customerService) : ControllerBase
    {
        private readonly CustomerService _customerService = customerService;

        [HttpGet("AllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _customerService.GetCustomersAsync();
            return Ok(customers);
        }

        [HttpGet("Customer/{No}")]
        public async Task<IActionResult> GetCustomerById(string No)
        {
            var customer = await _customerService.GetCustomerByIdAsync(No);

            if (customer != null)
            {
                return Ok(customer);
            }
            return NotFound();

        }


    }
}
using EmployeeAdminPortal.Interfaces;
using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController(ContactService contactService) : ControllerBase
    {
        private readonly ContactService _contactService = contactService;
        [HttpGet("AllContacts")]
        public async Task<IActionResult> GetAllContacts()
        {
            var contacts = await _contactService.GetContactsAsync();
            return Ok(contacts);
        }

        [HttpGet("Contact/{companyName}")]
        public async Task<IActionResult> GetContactByCompanyName(string companyName)
        {
            // URL encode the company name to handle special characters
            var encodedCompanyName = HttpUtility.UrlEncode(companyName);

            // Get all contacts for the given company name
            var contacts = await _contactService.GetContactByIdAsync(encodedCompanyName);

            if (contacts != null && contacts.Any())
            {
                return Ok(contacts); // Return the list of contacts
            }

            return NotFound(new { Message = "No contacts found for the given company name." }); // No matching contacts found
        }
    }
}
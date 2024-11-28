using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Threading.Tasks;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly ResourceService _resourceService;

        public ResourceController(ResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        // Get all resources or filter by type (Person/Room)
        [HttpGet("AllResources")]
        public async Task<IActionResult> GetAllResources([FromQuery] string type = "")
        {
            var resources = await _resourceService.GetResourcesAsync(type);
            return Ok(resources);
        }

        // Get a resource by its ID (No)
        [HttpGet("Resource/{resourceNo}")]
        public async Task<IActionResult> GetResourceById(string resourceNo)
        {
            var resource = await _resourceService.GetResourceByIdAsync(resourceNo);
            if (resource != null)
            {
                return Ok(resource);
            }
            return NotFound();
        }
    }
}

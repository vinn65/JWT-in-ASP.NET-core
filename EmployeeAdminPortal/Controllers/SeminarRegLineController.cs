using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static EmployeeAdminPortal.Services.SeminarRegLineService;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeminarRegLineController(SeminarRegLineService SeminarRegLineService)
    {
        private readonly SeminarRegLineService _controller = SeminarRegLineService;

        [Authorize(Roles = "Admin,user")]
        [HttpPost("RegLine")]
        public async Task<dynamic> PostRegLine(ReglineData reglineData)
        {
            var response = await _controller.RegLine(reglineData);
            return response!;
        }
    }
       
}

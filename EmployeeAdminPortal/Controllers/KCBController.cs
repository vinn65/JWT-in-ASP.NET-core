using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KcbController : Controller
    {
        private readonly KcbService _kcbService;

        public KcbController(KcbService kcbService)
        {
            _kcbService = kcbService;
        }

        [HttpGet("token")]
        public async Task<IActionResult> GetToken([FromQuery] string username, [FromQuery] string password)
        {
            var (accessToken, tokenType, expiresIn) = await _kcbService.FetchTokenAsync(username, password);

            // Returning each value independently in JSON format
            return Ok(new
            {
                access_token = accessToken,
                token_type = tokenType,
                expires_in = expiresIn
            });
        }
    }
}

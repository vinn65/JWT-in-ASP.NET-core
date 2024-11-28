using EmployeeAdminPortal.Interfaces;
using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeminarRegController(SeminarRegService seminarRegService): ControllerBase
    {
        private readonly SeminarRegService _seminarRegService = seminarRegService;

        [Authorize(Roles = "Admin,user")]
        [HttpPost("SeminarReg")]
        public async Task<dynamic> PostRegData(SeminarRegData seminarRegData)
        {
            var response = await _seminarRegService.PostData(seminarRegData);
            return response;

        }

        [HttpGet("Seminars")]
        public async Task<IActionResult> GetAllSeminars([FromQuery] string? name = null)
        {
            try
            {
                var seminars = await _seminarRegService.GetSeminarsAsync(name);
                if (seminars == null || !seminars.Any())
                {
                    return NotFound(new { Message = "No seminars found." });
                }

                return Ok(seminars);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "An error occurred while retrieving seminars.",
                    Details = ex.Message
                });
            }
        }



    }
}

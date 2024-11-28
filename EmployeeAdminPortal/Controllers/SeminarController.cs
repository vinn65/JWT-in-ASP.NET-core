using EmployeeAdminPortal.Interfaces;
using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeminarController(SeminarService seminarService, ISeminar seminar) : ControllerBase
    {
        private readonly SeminarService _SeminarService = seminarService;
        private readonly ISeminar _seminar = seminar;


        [HttpGet("AllSeminars")]
        public async Task<IActionResult> GetAllSeminars([FromQuery] string? name = null)
        {
            try
            {
                var seminars = await _SeminarService.GetSeminarsAsync(name);
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


        [HttpGet("Seminar/{docNo}")]
        public async Task<IActionResult> GetSeminarById(string docNo)
        {
            var seminar = await _SeminarService.GetSeminarDataByIdAsync(docNo);

            if (seminar != null)
            {
                return Ok(seminar);
            }
            return NotFound();

        }

        [HttpPost("InsertOrUpdate")]
        public async Task<dynamic> PostDataToBc(SeminarData seminarData)
        {
            var response = await _seminar.PostData(seminarData);
            return Ok(response);
        }

        [HttpDelete("Delete/{docNo}")]
        public async Task<IActionResult> DeleteSeminar(string docNo)
        {
            var result = await _SeminarService.DeleteSeminarAsync(docNo);

            if (result)
            {
                return Ok($"Seminar {docNo} Deleted Successfully.");
            }
            else
            {
                return NotFound();
            }
        }



    }
}
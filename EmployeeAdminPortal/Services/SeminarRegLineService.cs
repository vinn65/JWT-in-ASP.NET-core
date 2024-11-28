using EmployeeAdminPortal.Models;
using static EmployeeAdminPortal.Helpers.ErrorHelper;

namespace EmployeeAdminPortal.Services
{
    public class SeminarRegLineService(IConfiguration configuration, HttpClient HttpClient, Credentials Credentials)
    {
        private readonly IConfiguration _configuration = configuration;
        private readonly HttpClient _httpClient = HttpClient;
        private readonly Credentials _credentials = Credentials;


        public async Task<dynamic> RegLine(ReglineData regline)
        {
            try
            {
                var client = _credentials.ObjNav();
                await client.RegisterParticipantAsync
                    (
                        regline.DocumentNo,
                        regline.BillToCustomerNo,
                        regline.ParticipantContactNo
                    );
                return new ApiErrorResponse
                {
                    StatusCode = 200,
                    Message = "Seminar data posted successfully.",
                    Details = ""
                };
            }
            catch (Exception ex)
            {
                return new ApiErrorResponse
                {
                    StatusCode = 500,
                    Message = "An error occurred while posting seminar data.",
                    Details = ex.Message
                };
            }



        }

        public class ReglineData
        {
            public required string DocumentNo { get; set; }
            public required string BillToCustomerNo { get; set; }
            public required string ParticipantContactNo { get; set; }
        }
    }
}

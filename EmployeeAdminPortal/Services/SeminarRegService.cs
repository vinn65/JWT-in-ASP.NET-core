using EmployeeAdminPortal.Interfaces;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Helpers;
using static EmployeeAdminPortal.Helpers.ErrorHelper;
using System.Text.Json;

namespace EmployeeAdminPortal.Services
{
    public class SeminarRegService(HttpClient httpClient, IConfiguration configuration, Credentials credentials)
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly IConfiguration _config = configuration;
        private readonly Credentials _credentials = credentials;
        private string _baseUrl => _config.GetValue<string>("PortalBaseUrl")!;


        public async Task<dynamic> PostData(SeminarRegData seminarReg)
        {
            try
            {
                var client = _credentials.ObjNav();
                await client.InsertSeminarRegDataAsync(
                    seminarReg.seminarNo,
                    seminarReg.personNo,
                    seminarReg.roomNo
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

        public async Task<List<Seminars>> GetSeminarsAsync(string? name = null)
        {
            var filterQuery = string.IsNullOrWhiteSpace(name) ? string.Empty : $"?$filter=contains(Name, '{name}')";
            var url = $"{_baseUrl}/SeminarRegList{filterQuery}";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);

                if (jsonData.RootElement.TryGetProperty("value", out var seminars))
                {
                    return System.Text.Json.JsonSerializer.Deserialize<List<Seminars>>(seminars.ToString())!;
                }
            }
            else
            {
                var errorResponse = await ErrorHelper.HandleErrorResponse(response);
                throw new Exception(errorResponse.Message);
            }

            return new List<Seminars>();
        }

    }

    public class SeminarRegData
    {
        public string seminarNo { get; set; }
        public string personNo { get; set; }
        public string roomNo { get; set; }
    }

    public class Seminars
    {
        public string No { set; get; }
        public string Seminar_Name { get; set; }
        public string Status { get; set; }
        public int Duration { get; set; }

        public string Starting_Date { get; set; }
        public int Remaining_Participants { get; set; }
    }
}

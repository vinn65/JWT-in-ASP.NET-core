using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json;
using EmployeeAdminPortal.Interfaces;
using EmployeeAdminPortal.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using EmployeeAdminPortal.Helpers;
using static EmployeeAdminPortal.Helpers.ErrorHelper;

namespace EmployeeAdminPortal.Services
{
    public class SeminarService(HttpClient httpClient, IConfiguration configuration, Credentials credentials): ISeminar
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly IConfiguration _configuration = configuration;
        private readonly Credentials _credentials = credentials;

        private string _baseUrl => _configuration.GetValue<string>("PortalBaseUrl")!;


        public async Task<dynamic> PostData(SeminarData seminar)
        {
            try
            {
                var client = _credentials.ObjNav();
                await client.InsertSeminarDataAsync(
                                        seminar.DocNo,
                                        seminar.Name,
                                        seminar.SeminarDuration,
                                        seminar.SearchName,
                                        seminar.minParticipants,
                                        seminar.maxParticipants
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

        public async Task<List<SeminarDataGet>> GetSeminarsAsync(string? name = null)
        {
            var filterQuery = string.IsNullOrWhiteSpace(name) ? string.Empty : $"?$filter=contains(Name, '{name}')";
            var url = $"{_baseUrl}/SeminarList{filterQuery}";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);

                if (jsonData.RootElement.TryGetProperty("value", out var seminars))
                {
                    return System.Text.Json.JsonSerializer.Deserialize<List<SeminarDataGet>>(seminars.ToString())!;
                }
            }
            else
            {
                var errorResponse = await ErrorHelper.HandleErrorResponse(response);
                throw new Exception(errorResponse.Message);
            }

            return new List<SeminarDataGet>();
        }

        public async Task<SeminarDataGet> GetSeminarDataByIdAsync(string docNo)
        {
            var url = $"{_baseUrl}/SeminarList?$filter=No eq '{docNo}'";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);
                var seminar = jsonData.RootElement.GetProperty("value").EnumerateArray().FirstOrDefault();

                return System.Text.Json.JsonSerializer.Deserialize<SeminarDataGet>(seminar.ToString())!;
            }
            else
            {

                var errorResponse = await ErrorHelper.HandleErrorResponse(response);
                throw new Exception(errorResponse.Message);
            }

           
        }


        public async Task<bool> DeleteSeminarAsync(string docNo)
        {
            try
            {
                if (string.IsNullOrEmpty(docNo))
                {
                    throw new ArgumentException("Doc NO cannot be null.");
                }

                var url = $"{_baseUrl}/SeminarList('{docNo}')";
                var response = await _httpClient.DeleteAsync(url);

                if (response == null)
                {
                    Console.WriteLine("Response is null. Please check the service endpoint.");
                    return false;
                }

                // Log response status code for debugging
                Console.WriteLine($"Response Status Code: {response.StatusCode}");

                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"HTTP Request Exception: {httpEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }

    public class SeminarData
    {
        public string DocNo { get; set; }
        public string Name { get; set; }
        public int SeminarDuration { get; set; }
        public string SearchName { get; set; }
        public int minParticipants { get; set; }
        public int maxParticipants { get; set; }
    }

    public class SeminarDataGet
    {
        public string No { get; set; }
        public string Name { get; set; }
        public int Seminar_Duration { get; set; }
        public int Seminar_Price { get; set; }

    }
}


//}




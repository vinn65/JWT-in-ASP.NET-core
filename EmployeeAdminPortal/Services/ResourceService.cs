using EmployeeAdminPortal.Interfaces;
using EmployeeAdminPortal.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Design;
using EmployeeAdminPortal.Helpers;

namespace EmployeeAdminPortal.Services
{
    public class ResourceService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;
        private readonly string _baseUrl;

        public ResourceService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _config = configuration;
            _baseUrl = _config.GetValue<string>("PortalBaseUrl")!;
        }

        public async Task<List<ResourceData>> GetResourcesAsync(string typeFilter)
        {
            // Build URL for fetching resources with an optional filter for type (Person or Room)
            var url = string.IsNullOrEmpty(typeFilter)
                ? $"{_baseUrl}/ResourceList"
                : $"{_baseUrl}/ResourceList?$filter=Type eq '{typeFilter}'";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);
                if (jsonData.RootElement.TryGetProperty("value", out var resources))
                {
                    return JsonSerializer.Deserialize<List<ResourceData>>(resources.ToString())!;
                }
            }
            else
            {
                var errorResponse = await ErrorHelper.HandleErrorResponse(response);
                throw new Exception(errorResponse.Message);
            }

            return new List<ResourceData>();
        }

        public async Task<ResourceData> GetResourceByIdAsync(string resourceNo)
        {
            var url = $"{_baseUrl}/ResourceList?$filter=No eq '{resourceNo}'";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);
                var resource = jsonData.RootElement.GetProperty("value").EnumerateArray().FirstOrDefault();
                return JsonSerializer.Deserialize<ResourceData>(resource.ToString())!;
            }
            else
            {
                var errorResponse = await ErrorHelper.HandleErrorResponse(response);
                throw new Exception(errorResponse.Message);
            }

         ;
        }
    }

    public class ResourceData
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Maximum_Participants { get; set; }
        public string Base_Unit_of_Measure { get; set; }
        public decimal Direct_Unit_Cost { get; set; }
        public string Search_Name { get; set; }
    }
}

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
using System.Web;

namespace EmployeeAdminPortal.Services
{
    public class ContactService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;
        private readonly string _baseUrl;

        public ContactService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _config = configuration;
            _baseUrl = _config.GetValue<string>("PortalBaseUrl")!;
        }

        public async Task<List<contactData>> GetContactsAsync()
        {
            var url = $"{_baseUrl}/ContactsList";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);
                if (jsonData.RootElement.TryGetProperty("value", out var Contacts))
                {
                    return JsonSerializer.Deserialize<List<contactData>>(Contacts.ToString())!;
                }
            }
            else
            {
                var errorResponse = await ErrorHelper.HandleErrorResponse(response);
                throw new Exception(errorResponse.Message);
            }

            return new List<contactData>();
        }


        public async Task<List<contactData>> GetContactByIdAsync(string encodedCompanyName)
        {
            var url = $"{_baseUrl}/ContactsList";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);

                if (jsonData.RootElement.TryGetProperty("value", out var contacts))
                {
                    var contactList = JsonSerializer.Deserialize<List<contactData>>(contacts.ToString());

                    // Decode the company name if needed (optional)
                    var decodedCompanyName = HttpUtility.UrlDecode(encodedCompanyName);

                    // Filter contacts based on the decoded company name
                    var filteredContacts = contactList?.Where(c => c.Company_Name == decodedCompanyName).ToList();

                    return filteredContacts ?? new List<contactData>();
                }
            }
            else
            {
                var errorResponse = await ErrorHelper.HandleErrorResponse(response);
                throw new Exception(errorResponse.Message);
            }

            return new List<contactData>(); // Return an empty list if no data or error occurs
        }
    }

    public class contactData
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Business_Relation { get; set; }
        public string E_Mail { get; set; }

        public string Search_Name { get; set; }
        public string Company_Name { get; set; }
    }
}

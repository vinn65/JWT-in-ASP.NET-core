using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using EmployeeAdminPortal.Helpers;

namespace EmployeeAdminPortal.Services
{
    public class CustomerService
    {
        private readonly HttpClient _httpClient;
        private readonly string serviceRoot;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            serviceRoot = "http://machine:7048/BC240/ODataV4/Company('CRONUS%20International%20Ltd.')";
        }

        public async Task<List<CustomerDto>> GetCustomersAsync()
        {
            var url = $"{serviceRoot}/CustomerList";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);
                var customers = jsonData.RootElement.GetProperty("value");

                return JsonSerializer.Deserialize<List<CustomerDto>>(customers.ToString());
            }

            return new List<CustomerDto>();
        }

        public async Task<CustomerDto?> GetCustomerByIdAsync(string id)
        {
            var url = $"{serviceRoot}/CustomerList('{id}')";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CustomerDto>(jsonString);
            }

            return null;
        }

        public async Task<CustomerDto> CreateCustomerAsync(CustomerForCreateOrUpdateDto newCustomer, string token)
        {
            // Validate the token
            if (!TokenHelper.ValidateToken(token))
            {
                throw new UnauthorizedAccessException("Invalid token provided.");
            }

            var url = $"{serviceRoot}/CustomerCard";
            var jsonContent = JsonSerializer.Serialize(newCustomer);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CustomerDto>(jsonString);
        }
    }

    public class CustomerDto
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Post_Code { get; set; }
        public string Country_Region_Code { get; set; }
        public string Phone_No { get; set; }
        public string Currency_Code { get; set; }
        public string Salesperson_Code { get; set; }
        public string Customer_Posting_Group { get; set; }
        public string Last_Date_Modified { get; set; }
    }

    public class CustomerForCreateOrUpdateDto
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Name_2 { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country_Region_Code { get; set; }
        public string Post_Code { get; set; }
        public string Phone_No { get; set; }
        public string E_Mail { get; set; }
    }
}

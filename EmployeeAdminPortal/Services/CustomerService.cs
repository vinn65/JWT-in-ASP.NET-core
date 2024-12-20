﻿using EmployeeAdminPortal.Interfaces;
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
    public class CustomerService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;
        private readonly string _baseUrl;

        public CustomerService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _config = configuration;
            _baseUrl = _config.GetValue<string>("PortalBaseUrl")!;
        }

        public async Task<List<customerData>> GetCustomersAsync()
        {
            var url = $"{_baseUrl}/CustomerList";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);
                if (jsonData.RootElement.TryGetProperty("value", out var Customers))
                {
                    return JsonSerializer.Deserialize<List<customerData>>(Customers.ToString())!;
                }
            }
            else
            {
                var errorResponse = await ErrorHelper.HandleErrorResponse(response);
                throw new Exception(errorResponse.Message);
            }

            return new List<customerData>();
        }


        public async Task<customerData> GetCustomerByIdAsync(string No)
        {
            var url = $"{_baseUrl}/CustomersList";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonData = JsonDocument.Parse(jsonString);
                var Customer = jsonData.RootElement.GetProperty("value").EnumerateArray().FirstOrDefault();
                return JsonSerializer.Deserialize<customerData>(Customer.ToString())!;
            }
            else
            {
                var errorResponse = await ErrorHelper.HandleErrorResponse(response);
                throw new Exception(errorResponse.Message);
            }
            
        }
    }

    public class customerData
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Phone_No { get; set; }
        public string E_Mail { get; set; }

        public string Search_Name { get; set; }
    }
}

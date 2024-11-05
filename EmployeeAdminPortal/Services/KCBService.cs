using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace EmployeeAdminPortal.Services
{
    public class KcbService
    {
        private readonly HttpClient _httpClient;

        public KcbService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<(string AccessToken, string TokenType, int ExpiresIn)> FetchTokenAsync(string username, string password)
        {
            var url = "https://uat.buni.kcbgroup.com/token?grant_type=client_credentials";
            var authToken = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            var response = await _httpClient.PostAsync(url, null);
            response.EnsureSuccessStatusCode(); // Exception if not success

            var jsonResponse = await response.Content.ReadAsStringAsync();

            // Deserialize the JSON response
            var jsonDocument = JsonDocument.Parse(jsonResponse);
            var accessToken = jsonDocument.RootElement.GetProperty("access_token").GetString();
            var tokenType = jsonDocument.RootElement.GetProperty("token_type").GetString();
            var expiresIn = jsonDocument.RootElement.GetProperty("expires_in").GetInt32();

            return (accessToken!, tokenType!, expiresIn); 
        }
    }
}

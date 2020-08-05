using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace TRON_API.Library.Helpers
{
    internal static class HttpHelper
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions()
        {
            
            PropertyNameCaseInsensitive = true,
            IgnoreNullValues = true
        };

        internal static async Task<T> GetAsync<T>(string url) where T : class
        {
            var response = await _httpClient.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<T>(responseString, _jsonSerializerOptions);
            return result;
        }

        internal static async Task<T> PostAsync<T>(string url, string? json_request = null) where T : class
        {
            HttpContent content = new StringContent(json_request);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PostAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<T>(responseString, _jsonSerializerOptions);
            return result;
        }

        internal static async Task<T> PutAsync<T>(string url, string? json_request = null) where T : class
        {
            HttpContent content = new StringContent(json_request);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _httpClient.PutAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<T>(responseString, _jsonSerializerOptions);
            return result;
        }

        internal static async Task<T> DeleteAsync<T>(string url) where T : class
        {
            var response = await _httpClient.DeleteAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<T>(responseString, _jsonSerializerOptions);
            return result;
        }
    }
}
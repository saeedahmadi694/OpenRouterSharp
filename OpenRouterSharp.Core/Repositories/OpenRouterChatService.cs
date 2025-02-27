using System;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using OpenRouterSharp.Core.Models;
using OpenRouterSharp.Core.InfraServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace OpenRouterSharp.Core.Repositories
{

    public class OpenRouterChatService : IOpenRouterChatService
    {
        private readonly string _apiKey;
        private readonly string _baseUrl;
        private static readonly HttpClient _httpClient = new HttpClient();
        public OpenRouterChatService(string baseUrl,string apiKey)
        {
            _apiKey = apiKey;
            _baseUrl = baseUrl;
        }

        public async Task<ChatResponse> SendMessageAsync(ChatRequest chatRequest)
        {
            var requestJson = JsonSerializer.Serialize(chatRequest);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

            var response = await _httpClient.PostAsync(_baseUrl, content);
            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<ChatResponse>(responseJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
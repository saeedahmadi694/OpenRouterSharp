using System;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using OpenRouterSharp.Core.Models;
using OpenRouterSharp.Core.InfraServices;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace OpenRouterSharp.Core.Repositories
{
    public class OpenRouterChatService : IOpenRouterChatService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _baseUrl;

        public OpenRouterChatService(HttpClient httpClient, string baseUrl, string apiKey)
        {
            _httpClient = httpClient;
            _baseUrl = baseUrl;
            _apiKey = apiKey;

            // Add the Authorization header once per instance
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        }

        public async Task<PropmtResponse> SendMessageAsync(PropmtRequest chatRequest)
        {
            var requestJson = JsonSerializer.Serialize(chatRequest);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{_baseUrl}/completions", content);
            response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<PropmtResponse>(responseJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<ChatResponse> ChatMessageAsync(ChatRequest chatRequest)
        {
            var requestJson = JsonSerializer.Serialize(chatRequest);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{_baseUrl}/chat/completions", content);
            response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ChatResponse>(responseJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }

}
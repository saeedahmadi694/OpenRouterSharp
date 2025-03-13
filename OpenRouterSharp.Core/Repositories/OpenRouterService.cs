using OpenRouterSharp.Core.InfraServices;
using System;
using System.Net.Http;

namespace OpenRouterSharp.Core.Repositories
{

    public class OpenRouterService : IOpenRouterService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _apiKey;
        private readonly string _baseUrl;

        public OpenRouterService(string baseUrl, string apiKey)
        {
            _httpClientFactory = new DefaultHttpClientFactory();
            _apiKey = apiKey;
            _baseUrl = baseUrl;
        }

        private IOpenRouterChatService _openRouterChatService;
        public IOpenRouterChatService OpenRouterChatService
        {
            get
            {
                if (_openRouterChatService == null)
                {
                    var httpClient = _httpClientFactory.CreateClient();
                    _openRouterChatService = new OpenRouterChatService(httpClient, _baseUrl, _apiKey);
                }
                return _openRouterChatService;
            }
        }
    }
    public class DefaultHttpClientFactory : IHttpClientFactory
    {
        public HttpClient CreateClient(string name = "")
        {
            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromMinutes(20);
            return httpClient;
        }
    }
}

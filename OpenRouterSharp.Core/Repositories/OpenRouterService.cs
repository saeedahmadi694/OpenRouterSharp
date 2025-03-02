using OpenRouterSharp.Core.InfraServices;
using System;

namespace OpenRouterSharp.Core.Repositories
{

    public class OpenRouterService : IOpenRouterService
    {
        private readonly string _apiKey;
        private readonly string _baseUrl;

        public OpenRouterService(string baseUrl, string apiKey)
        {
            _baseUrl = baseUrl;
            _apiKey = apiKey;
        }

        private IOpenRouterChatService _openRouterChatService;
        public IOpenRouterChatService OpenRouterChatService
        {
            get
            {
                _openRouterChatService ??= new OpenRouterChatService(_baseUrl, _apiKey);
                return _openRouterChatService;
            }
        }
    }
}
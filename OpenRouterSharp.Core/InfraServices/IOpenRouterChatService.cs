using OpenRouterSharp.Core.Models;
using System.Threading.Tasks;

namespace OpenRouterSharp.Core.InfraServices
{

    public interface IOpenRouterChatService
    {
        Task<ChatResponse> SendMessageAsync(ChatRequest chatRequest);
    }
}

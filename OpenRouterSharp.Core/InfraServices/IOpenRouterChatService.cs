using OpenRouterSharp.Core.Models;
using System.Threading.Tasks;

namespace OpenRouterSharp.Core.InfraServices
{

    public interface IOpenRouterChatService
    {
        Task<PropmtResponse> SendMessageAsync(PropmtRequest chatRequest);
        Task<ChatResponse> ChatMessageAsync(ChatRequest chatRequest);
    }
}

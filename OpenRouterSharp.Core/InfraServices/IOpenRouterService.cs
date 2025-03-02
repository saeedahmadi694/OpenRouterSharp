using OpenRouterSharp.Core.Models;
using System.Threading.Tasks;

namespace OpenRouterSharp.Core.InfraServices
{

    public interface IOpenRouterService
    {
        public IOpenRouterChatService OpenRouterChatService { get; }
    }
}

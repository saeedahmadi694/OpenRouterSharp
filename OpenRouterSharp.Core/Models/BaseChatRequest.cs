using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenRouterSharp.Core.Models
{
    public abstract class BaseChatRequest
    {
        [JsonPropertyName("model")]
        public string Model { get; set; }
        [JsonPropertyName("stream")]
        public bool Stream { get; set; }
    }

    public class PropmtRequest : BaseChatRequest
    {
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }
    }
    public class ChatRequest : BaseChatRequest
    {
        [JsonPropertyName("messages")]
        public List<Message> Messages { get; set; }

        //[JsonPropertyName("models")]
        //public List<string>? Models { get; set; } // Added for model routing

        //[JsonPropertyName("route")]
        //public string? Route { get; set; } // Optional fallback routing

        //[JsonPropertyName("provider")]
        //public ProviderPreferences? Provider { get; set; } // Added for provider routing

        //[JsonPropertyName("plugins")]
        //public List<Plugin>? Plugins { get; set; } // Added plugin configuration
    }

}
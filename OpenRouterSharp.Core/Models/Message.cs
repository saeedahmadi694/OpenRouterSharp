using System.Text.Json.Serialization;

namespace OpenRouterSharp.Core.Models
{
    public class Message
    {
        [JsonPropertyName("role")]
        public string Role { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; }
        [JsonPropertyName("refusal")]
        public object Refusal { get; set; }
        [JsonPropertyName("reasoning")]
        public object Reasoning { get; set; }
    }

}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenRouterSharp.Core.Models
{
    public abstract class BaseChatResponse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("provider")]
        public string? Provider { get; set; }
        [JsonPropertyName("model")]
        public string? Model { get; set; }
        [JsonPropertyName("@object")]
        public string? Object { get; set; }
        [JsonPropertyName("created")]
        public int Created { get; set; }
        [JsonPropertyName("usage")]
        public Usage? Usage { get; set; }
    }

    public class ChatResponse : BaseChatResponse
    {
        [JsonPropertyName("choices")]
        public List<ChatChoice>? Choices { get; set; }

        public string GetReply()
        {
            return Choices?.Count > 0 ? Choices[0].Message.Content : string.Empty;
        }
    }
    public class PropmtResponse : BaseChatResponse
    {
        [JsonPropertyName("choices")]
        public List<PropmtChoice>? Choices { get; set; }
        [JsonPropertyName("message")]
        public string Message => Choices?.Count > 0 ? Choices[0].Text : string.Empty;

    }



}
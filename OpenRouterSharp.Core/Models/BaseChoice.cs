using System.Collections.Generic;
using System.Text.Json.Serialization;
using static OpenRouterSharp.Core.Models.PropmtResponse;

namespace OpenRouterSharp.Core.Models
{
    public abstract class BaseChoice
    {
        [JsonPropertyName("logprobs")]
        public object Logprobs { get; set; }
        [JsonPropertyName("finish_reason")]
        public string FinishReason { get; set; }
        [JsonPropertyName("native_finish_reason")]
        public string NativeFinishReason { get; set; }
    }
    public class PropmtChoice : BaseChoice
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
    public class ChatChoice : BaseChoice
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }
        [JsonPropertyName("message")]
        public Message Message { get; set; }
    }
}


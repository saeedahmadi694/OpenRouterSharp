using System.Collections.Generic;
using System.Text.Json.Serialization;
using static OpenRouterSharp.Core.Models.PropmtResponse;

namespace OpenRouterSharp.Core.Models
{
    public class Usage
    {
        [JsonPropertyName("prompt_tokens")]
        public int PromptTokens { get; set; }
        [JsonPropertyName("completion_tokens")]
        public int CompletionTokens { get; set; }
        [JsonPropertyName("total_tokens")]
        public int TotalTokens { get; set; }
    }
}


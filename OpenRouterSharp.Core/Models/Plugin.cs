using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenRouterSharp.Core.Models
{
    public class Plugin
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("max_results")]
        public int MaxResults { get; set; }
        [JsonPropertyName("search_prompt")]
        public string SearchPrompt { get; set; }
    }
}
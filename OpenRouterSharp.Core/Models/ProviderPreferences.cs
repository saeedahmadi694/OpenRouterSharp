using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenRouterSharp.Core.Models
{
    public class ProviderPreferences
    {
        [JsonPropertyName("order")]
        public List<string> Order { get; set; }
        [JsonPropertyName("allow_fallbacks")]
        public bool? AllowFallbacks { get; set; } = true;
        [JsonPropertyName("require_parameters")]
        public bool? RequireParameters { get; set; } = false;
        [JsonPropertyName("data_collection")]
        public string DataCollection { get; set; } = "allow";
        [JsonPropertyName("ignore")]
        public List<string> Ignore { get; set; }
        [JsonPropertyName("quantizations")]
        public List<string> Quantizations { get; set; }
        [JsonPropertyName("sort")]
        public string Sort { get; set; }
    }
}
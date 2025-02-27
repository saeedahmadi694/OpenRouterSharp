using System.Collections.Generic;

namespace OpenRouterSharp.Core.Models
{
    public class ChatRequest
    {
        public string Model { get; set; }
        public List<Message> Messages { get; set; }
        public List<string> Models { get; set; } // Added for model routing
        public string Route { get; set; } // Optional fallback routing
        public ProviderPreferences Provider { get; set; } // Added for provider routing
        public List<Plugin> Plugins { get; set; } // Added plugin configuration
    }


    public class ProviderPreferences
    {
        public List<string> Order { get; set; }
        public bool? AllowFallbacks { get; set; } = true;
        public bool? RequireParameters { get; set; } = false;
        public string DataCollection { get; set; } = "allow";
        public List<string> Ignore { get; set; }
        public List<string> Quantizations { get; set; }
        public string Sort { get; set; }
    }
    public class Plugin
    {
        public string Id { get; set; }
        public int MaxResults { get; set; }
        public string SearchPrompt { get; set; }
    }
}
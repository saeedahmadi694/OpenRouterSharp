using System.Collections.Generic;

namespace OpenRouterSharp.Core.Models
{
    public class ChatResponse
    {
        public List<Choice> Choices { get; set; }

        public class Choice
        {
            public Message Message { get; set; }
        }

        public string GetReply()
        {
            return Choices?.Count > 0 ? Choices[0].Message.Content : string.Empty;
        }
    }
}

using System;

namespace OpenRouterSharp.Core.ExceptionHandler
{
    public class VandarApiException : Exception
    {
        public string ResponseContent { get; }

        public VandarApiException(string message, string responseContent = null) : base(message)
        {
            ResponseContent = responseContent;
        }

        public VandarApiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

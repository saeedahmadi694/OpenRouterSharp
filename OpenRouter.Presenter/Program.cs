// See https://aka.ms/new-console-template for more information
using OpenRouterSharp.Core.Models;
using OpenRouterSharp.Core.Repositories;

Console.WriteLine("Hello, World!");

string apiKey = "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";
string baseUrl = "https://openrouter.ai/api/v1/chat/completions";

var chatService = new OpenRouterChatService(baseUrl,apiKey);
var chatRequest = new ChatRequest
{
    Model = "deepseek/deepseek-r1:free", // Using the online version to allow web search
    //Models = new List<string> { "deepseek/deepseek-r1:free" }, // Model fallback
    //Route = "fallback", // Optional fallback routing
    //Provider = new ProviderPreferences
    //{
    //    //Order = new List<string> { "deepseek/deepseek-r1:free" },
    //    AllowFallbacks = true,
    //    Sort = "throughput",
    //    //Ignore = new List<string> { "Azure" },
    //    //DataCollection = "deny"
    //},
    //Plugins =
    //        [
    //            new Plugin
    //            {
    //                Id = "web",
    //                MaxResults = 5, // Number of web search results
    //                SearchPrompt = "Here are some relevant web results. Please incorporate them into your answer and cite the sources using markdown links."
    //            }
    //        ],
    Messages = [new Message { Role = "user", Content = "What is the latest trend in AI for 2025?" }]
};

ChatResponse response = await chatService.SendMessageAsync(chatRequest);
//Console.WriteLine($"Used Model: {response.Model}");
Console.WriteLine(response.GetReply());
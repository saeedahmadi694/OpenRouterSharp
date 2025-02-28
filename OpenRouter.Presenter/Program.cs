// See https://aka.ms/new-console-template for more information
using OpenRouterSharp.Core.Models;
using OpenRouterSharp.Core.Repositories;

Console.WriteLine("Hello, World!");

string apiKey = "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";
string baseUrl = "https://openrouter.ai/api/v1";

var chatService = new OpenRouterChatService(baseUrl,apiKey);
var chatRequest = new PropmtRequest
{
    Prompt = "hi who are you ?",
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
    //messages = [new Message { role = "user", content = "What is the latest trend in AI for 2025?" }]
};

var response = await chatService.SendMessageAsync(chatRequest);
//Console.WriteLine($"Used Model: {response.Model}");
Console.WriteLine(response.Message);
using System;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

var deploymentName = "gpt-4.1";
var endpoint = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")
               ?? throw new InvalidOperationException("AZURE_OPENAI_ENDPOINT environment variable is not set.");
var apiKey = Environment.GetEnvironmentVariable("AZURE_OPENAI_API_KEY")
            ?? throw new InvalidOperationException("AZURE_OPENAI_API_KEY environment variable is not set.");

var kernel = Kernel.CreateBuilder()
    .AddAzureOpenAIChatCompletion(deploymentName, endpoint, apiKey)
    .Build();

var ChatCompletionService = kernel.GetRequiredService<IChatCompletionService>();

while (true)
{
    Console.Write("User: ");
    var prompt = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(prompt)) break;
    var response = await ChatCompletionService.GetChatMessageContentAsync(prompt);
    Console.WriteLine($"Bot: {response}");
}


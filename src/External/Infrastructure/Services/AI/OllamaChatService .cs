using Application.DTOs.Response;
using System.Net.Http.Json;

namespace Infrastructure.Services;

public class OllamaChatService : IChatService
{
    private bool disposedValue;
    //private readonly IChatClient _chatClient;
    private readonly HttpClient _client;
    public OllamaChatService(HttpClient client)
    {
        _client = client;
    }

    public async Task<string> AskQuestion(string question)
    {
        var apiUrl = "http://localhost:11434/api/chat";
        var payload = new
        {
            model = "deepseek-r1:8b",
            message = new[]
            {
                new
                {
                    role = "user",
                    content = question
                }
            }
        };
        string jsonPayload = JsonSerializer.Serialize(payload);
        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        var response = await _client.PostAsync(apiUrl, content);
        response.EnsureSuccessStatusCode();
        var responseContent = await response.Content.ReadAsStringAsync();
        return responseContent;
    }

    public async Task<DeepSeekResponse> AskQuestionDeepSeekAsync(string question)
    {
        // Prepare the request payload
        var requestPayload = new
        {
            Question = question,
            Model = "deepseek-r1:8b"
        };

        // Send the request to DeepSeek
        var response = await _client.PostAsJsonAsync("https://api.deepseek.com/v1/ask", requestPayload);

        // Ensure the request was successful
        response.EnsureSuccessStatusCode();

        // Deserialize the response
        var responseContent = await response.Content.ReadAsStringAsync();
        var deepSeekResponse = JsonSerializer.Deserialize<DeepSeekResponse>(responseContent);


        var token = deepSeekResponse.Answer.Split(' ').ToList();
        DeepSeekResponse formattedResponse = new()
        {
            Answer = deepSeekResponse.Answer,
            Tokens = token,
            Confidence = deepSeekResponse.Confidence,
        };

        return formattedResponse;
    }
}


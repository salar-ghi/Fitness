using System.Text.Json;

namespace Presentation.Services;

public class GrokService
{
    private readonly HttpClient _client;
    private readonly string _apiBaseUrl;

    public GrokService(IHttpClientFactory client, IConfiguration configuration)
    {
        _client = client.CreateClient();
        var apiKey = configuration["Grok:ApiKey"];
        _apiBaseUrl = configuration["Grok:BaseUrl"];
        _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        _client.DefaultRequestHeaders.Add("Accept", "application/json");
    }

    public async Task<string> AskQuestionAsync(string question)
    {
        var requestBody = new
        {
            model = "grok-3",
            messages = new[]
            {
                new { role = "user", content = question },
            },
            max_tokens = 250,
            temperature = 0.7
        };

        string json = JsonSerializer.Serialize(requestBody, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        });
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        Console.Clear();
        Console.WriteLine($"Sending request: {json}");


        var response = await _client.PostAsync($"{_apiBaseUrl}/chat/completions", content);
        string responseJson = await response.Content.ReadAsStringAsync();
        Console.Clear();
        Console.WriteLine($"Response Status: {response.StatusCode}, Content: {responseJson}");
        
        try
        {
            var responseObject = JsonSerializer.Deserialize<JsonElement>(responseJson);
            string answer = responseObject.GetProperty("choices")[0]
                                         .GetProperty("message")
                                         .GetProperty("content")
                                         .GetString();
            return answer ?? "No response received";
        }
        catch (Exception ex)
        {
            return (ex.Message);
        }
    }

}
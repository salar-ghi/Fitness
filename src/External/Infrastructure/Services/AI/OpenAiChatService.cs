using System.Net.Http;
using System.Net.Http.Json;

namespace Infrastructure.Services.AI;

public class OpenAiChatService //: IOpenAiChatService
{
    private readonly HttpClient _httpClient;
    public OpenAiChatService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetResponse(string question)
    {
        var request = new
        {
            model = "llama3.2",
            prompt = question,
            stream = false
        };

        //var apiUrl = "http://localhost:11434/api/chat";
        //var payload = new
        //{
        //    model = "deepseek-r1:8b",
        //    message = new[]
        //    {
        //        new
        //        {
        //            role = "user",
        //            content = question
        //        }
        //    }
        //};
        //string jsonPayload = JsonSerializer.Serialize(payload);
        //var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        //var response = await _httpClient.PostAsJsonAsync(apiUrl, content);

        var response = await _httpClient.PostAsJsonAsync("api/generate", request);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<OllamaResponse>();
        return result?.Response;
    }
    private record OllamaResponse(string Response);
}

public class ApiResponse
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public string Tokens { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

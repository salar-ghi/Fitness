using OpenAI;
using System.Text.Json.Serialization;

namespace Presentation.Services;

public interface IDeepSeekService
{
    Task<string> GetResponseAsync(string prompt);
}

public class DeepSeekService : IDeepSeekService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<DeepSeekService> _logger;

    private readonly OpenAIClient _client;
    public DeepSeekService(HttpClient httpClient,
        ILogger<DeepSeekService> logger, OpenAIClient client)
    {
        _httpClient = httpClient;
        //_httpClient = httpClientFactory.CreateClient();
        _logger = logger;
        _client = client;
    }

    public async Task<string> GetResponseAsync(string prompt)
    {
        try
        {
            const string endpointPath = "chat/completions";
            var request = new List<DeepSeekRequest>
            {
                new ()
                {
                    Messages =
                    {
                        new ChatMessage
                        {
                            Role = "user",
                            Content = prompt
                        }
                    }
                }
            };
            var response = await _httpClient.PostAsJsonAsync(endpointPath, request);
            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadFromJsonAsync<DeepSeekResponse>();
            return responseData?.Choices.FirstOrDefault()?.Message.Content ?? "No response";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting DeepSeek response");
            return "Sorry, I encountered an error processing your request";
        }
    }
}



public class DeepSeekRequest
{
    [JsonPropertyName("model")]
    //public string Model { get; set; } = "deepseek-chat-lite";

    public string Model { get; set; } = "deepseek-reasoner";

    //public string Model { get; set; } = "deepseek-r1";

    [JsonPropertyName("temperature")]
    public float Temperature { get; set; } = 0.7f; // Often required

    [JsonPropertyName("messages")]
    public List<ChatMessage> Messages { get; set; } = new();

    [JsonPropertyName("max_tokens")]
    public int MaxTokens { get; set; } = 2000;
    // Add required parameters from DeepSeek docs
    [JsonPropertyName("stream")]
    public bool Stream { get; set; } = false;

    [JsonPropertyName("top_p")]
    public float TopP { get; set; } = 1.0f;
}

public class ChatMessage
{
    [JsonPropertyName("role")]
    public string Role { get; set; } = "user";

    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
}

public class DeepSeekResponse
{
    [JsonPropertyName("choices")]
    public List<ChatChoice> Choices { get; set; } = new();
}

public class ChatChoice
{
    [JsonPropertyName("message")]
    public ChatMessage Message { get; set; } = new();
}
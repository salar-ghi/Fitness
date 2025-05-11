using System.Text.Json;

namespace Presentation.Services;

public class OpenAiService
{


    //private readonly OpenAIAPI _openAiApi;
    private readonly HttpClient _client;
    private readonly string _apiBaseUrl;

    public OpenAiService(IHttpClientFactory client, IConfiguration configuration)
    {
        _client = client.CreateClient();
        var apiKey = configuration["OpenAI:ApiKey"];
        _apiBaseUrl = configuration["OpenAI:BaseUrl"];
        _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        _client.DefaultRequestHeaders.Add("Accept", "application/json");
    }

    public async Task<string> AskQuestionAsync(string question)
    {
        
        var requestBody = new
        {
            model = "gpt-3.5-turbo",
            //model = "gpt-o3",
            messages = new[]
            {
                new { role = "user", content = question }
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

        // Log the request for debugging
        Console.WriteLine($"Sending request: {json}");

        // Send POST request to OpenAI's API
        var response = await _client.PostAsync($"{_apiBaseUrl}/chat/completions", content);
        string responseJson = await response.Content.ReadAsStringAsync();

        // Log the response for debugging
        Console.WriteLine($"Response Status: {response.StatusCode}, Content: {responseJson}");

        // Check for error responses
        if (!response.IsSuccessStatusCode)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return "Error: Invalid API key. Please check your OpenAI API key in appsettings.json.";
            }
            if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
            {
                return "Error: Rate limit exceeded. Please check your OpenAI usage limits or try again later.";
            }
            if (responseJson.Contains("You exceeded your current quota"))
            {
                return "Error: Insufficient credits. Please add funds to your OpenAI account at https://platform.openai.com/account/billing.";
            }
            return $"Error: {response.StatusCode} - {responseJson}";
        }

        // Parse the response
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
            return $"Error parsing response: {ex.Message} - Raw response: {responseJson}";
        }
    }

}

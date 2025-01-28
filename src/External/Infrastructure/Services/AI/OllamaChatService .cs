using Application.DTOs.Response;
using SharpToken;
using System.Net.Http;
using System.Net.Http.Json;

namespace Infrastructure.Services;

public class OllamaChatService : IChatService
{
    private bool disposedValue;
    private readonly IChatClient _chatClient;
    private readonly HttpClient _client;
    private readonly OllamaResponseParser _parser;
    public OllamaChatService(IChatClient chatClient, OllamaResponseParser parser, HttpClient client)
    {
        _chatClient = chatClient;
        _parser = parser;
        _client = client;
    }

    public async Task<string> AskQuestion(string question)
    {
        //var requestBody = new
        //{
        //    prompt = question,
        //    max_tokens = 100,
        //};
        //var content = new StringContent(
        //    System.Text.Json.JsonSerializer.Serialize(requestBody),
        //    Encoding.UTF8, "application/json");
        //var url = "http://localhost:11434/api/generate";

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
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> AskQuestionAsync(string question)
    {
        var response = await _chatClient.CompleteAsync(question);
        var hierarchicalItems = _parser.ParseResponse(response.Message.ToString());

        return hierarchicalItems.ToString();
    }

    public async Task<DeepSeekResponse> AskQuestionDeepSeekAsync(string question)
    {
        // Prepare the request payload
        var requestPayload = new
        {
            Question = question,
            Model = "deepseek-engine"
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

    public async Task<string> ParseResponseAsync(string jsonResponse)
    {
        var ollamaResponse = JsonSerializer.Deserialize<OllamaResponse>(jsonResponse);
        return ollamaResponse?.Response;
    }



    public string FormatResponse(string response)
    {
        var text = response.ToString();


        return text;
    }
        

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
            }

            disposedValue = true;
        }
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

public class Tokenizer
{
    private static readonly GptEncoding Encoding = GptEncoding.GetEncoding("cl100k_base");

    public static List<string> Tokenize(string text)
    {
        var tokens = Encoding.Encode(text);
        return tokens.Select(t => t.ToString()).ToList();
    }
}

public class HierarchicalItem
{
    public string Name { get; set; }
    public List<HierarchicalItem> Children { get; set; }

    public HierarchicalItem()
    {
        Children = new List<HierarchicalItem>();
    }
}


public class OllamaResponseParser
{
    public List <HierarchicalItem> ParseResponse(string response)
    {
        var items = new List<HierarchicalItem>();
        var lines = response.Split(new[] {Environment.NewLine}, StringSplitOptions.None);

        HierarchicalItem currentItem = null;
        int indentLevel = 0;

        foreach (var line in lines)
        {
            var trimmedLine = line.Trim();
            var newIndentLevel = GetIndentLevel(line);

            if (newIndentLevel > indentLevel)
            {
                // New child item
                var childItem = new HierarchicalItem { Name = trimmedLine };
                if (currentItem != null)
                {
                    currentItem.Children.Add(childItem);
                }
                else
                {
                    items.Add(childItem);
                }
                currentItem = childItem;
            }
            else if (newIndentLevel < indentLevel)
            {
                // Move back up the hierarchy
                while (newIndentLevel < indentLevel)
                {
                    currentItem = GetParentItem(currentItem, items);
                    indentLevel--;
                }
            }
            else
            {
                var newItem = new HierarchicalItem { Name = trimmedLine };
                items.Add(newItem);
                currentItem = newItem;
            }
        }
        return items;
    }

    private int GetIndentLevel(string line)
    {
        return line.Length -line.TrimStart().Length;
    }

    private HierarchicalItem GetParentItem(HierarchicalItem item, List<HierarchicalItem> items)
    {
        foreach (var parent in items)
        {
            if (parent.Children.Contains(item))
            {
                return parent;
            }
        }
        return null;
    }


}


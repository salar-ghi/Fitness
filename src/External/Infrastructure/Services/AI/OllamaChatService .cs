using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.AI;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.Text.Json;

namespace Infrastructure.Services;

public class OllamaChatService : IChatService
{
    private bool disposedValue;
    private readonly IChatClient _chatClient;
    private readonly OllamaResponseParser _parser;
    public OllamaChatService(IChatClient chatClient, OllamaResponseParser parser)
    {
        _chatClient = chatClient;
        _parser = parser;
    }


    public async Task<string> AskQuestionAsync(string qustion)
    {
        
        var response = await _chatClient.CompleteAsync(qustion);
        //var message = response.Message;
        
        var hierarchicalItems = _parser.ParseResponse(response.Message.ToString());

        return hierarchicalItems.ToString();
    }

    private string ExtractRelevantParts(string response)
    {
        // Assuming the response is in JSON format; adjust as necessary for your response structure.
        using JsonDocument doc = JsonDocument.Parse(response);

        // Extract specific parts of the response based on your needs.
        // For example, if you want to extract a field called "message":
        if (doc.RootElement.TryGetProperty("message", out JsonElement messageElement))
        {
            return messageElement.GetString() ?? "No message found";
        }

        if (doc.RootElement.TryGetProperty("Weeks", out JsonElement weekElement))
        {
            return weekElement.GetString() ?? "No Weeks fond";
        }



        return "No relevant data found";
    }

    public TService? GetService<TService>(object? key = null) where TService : class
    {
        throw new NotImplementedException();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~OllamaChatService()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
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


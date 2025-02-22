namespace Infrastructure.Models;

public class OllamaResponse
{
    [JsonPropertyName("response")]
    public string Response { get; set; }
}

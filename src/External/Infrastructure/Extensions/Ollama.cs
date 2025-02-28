namespace Infrastructure.Extensions;

public class Ollama
{
    public async Task<string> ParseResponseAsync(string jsonResponse)
    {
        //var ollamaResponse = JsonSerializer.Deserialize<OllamaResponse>(jsonResponse);
        //return ollamaResponse?.Response;
        return jsonResponse;
    }

    public string FormatResponseAsTable(string response)
    {
        // Split the response into parts (e.g., sentences or paragraphs)
        var parts = response.Split(new[] { '\n', '.' }, StringSplitOptions.RemoveEmptyEntries);

        // Create a table structure
        var table = new System.Text.StringBuilder();
        table.AppendLine("| Part Number | Content |");
        table.AppendLine("|-------------|---------|");

        for (int i = 0; i < parts.Length; i++)
        {
            table.AppendLine($"| {i + 1} | {parts[i].Trim()} |");
        }

        return table.ToString();
    }

}

using Azure;
using Azure.Identity;

namespace Infrastructure.Extensions;

public class AzureTextAnalyticsService
{
    private readonly TextAnalyticsClient _client;

    public AzureTextAnalyticsService(string endpoint, string key)
    {
        _client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(key));
    }

    public async Task<string[]> ExtractKeyPhrasesAsync(string text)
    {
        var response = await _client.ExtractKeyPhrasesAsync(text);
        return response.Value.ToArray();
    }

    public async Task<string[]> SplitTextIntoParagraphsAsync(string text)
    {
        //var sentences = await _client.RecognizeSentencesAsync(text);
        var sentences = await _client.RecognizeEntitiesAsync(text);
        return sentences.Value.Select(s => s.Text).ToArray();
    }

}

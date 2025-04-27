using OllamaSharp;

namespace Infrastructure.Services.AI;

public class GrokAiService 
{
    private readonly HttpClient _httpClient; // For calling Ollama API
    private readonly IOllamaApiClient _ollama;

    public GrokAiService(IHttpClientFactory httpClientFactory,
        IOllamaApiClient ollama )
    {
        _httpClient = httpClientFactory.CreateClient("OllamaClient");
        _ollama = ollama;
    }

    public async Task GenerateFitnessPlanAsync(string prmpt)
    {
        var aiPrompt = prmpt;
        //string aiPrompt = "Generate a 1-week fitness plan.";
        //var response1 = await _ollama.GenerateAsync(aiPrompt).StreamToEndAsync().ConfigureAwait(false);
        //var result = response1.Response;

        var request = new
        {
            model = "llama3.1:8b",
            //model = "deepseek-r1:8b",
            prompt = aiPrompt,
            stream = false,
        };
        Console.Clear();
        Console.WriteLine($"time is {DateTime.Now.TimeOfDay}");
        var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("/api/generate", content);
        Console.WriteLine($"time is {DateTime.Now.TimeOfDay}");


        var responseText = await response.Content.ReadAsStringAsync();
        var ollamaResponse = JsonSerializer.Deserialize<OllamaResponse>(responseText);
        var planText = ollamaResponse.Response;
        

        //var modelResponse = _parser.Parse(planText);
        //return jsonResponse;

    }
}

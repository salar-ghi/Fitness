using OllamaSharp;

namespace Infrastructure.Services.AI;

public interface IGrokAiService
{
    Task<FitnessPlan> GenerateFitnessPlanAsync(string prmpt);
}
public class GrokAiService : IGrokAiService
{
    private readonly HttpClient _httpClient; // For calling Ollama API
    private readonly GrokPlanParser _parser;
    private readonly IOllamaApiClient _ollama;

    public GrokAiService(IHttpClientFactory httpClientFactory,
        IOllamaApiClient ollama )
    {
        _httpClient = httpClientFactory.CreateClient("OllamaClient");
        _parser = new GrokPlanParser();
        _ollama = ollama;
    }


    public FitnessPlan ParseFitnessPlan(string jsonResponse)
    {
        return JsonSerializer.Deserialize<FitnessPlan>(jsonResponse);
    }


    string ExtractJsonFromResponse(string responseText)
    {
        int jsonStart = responseText.IndexOf("```json") + "```json".Length;
        int jsonEnd = responseText.LastIndexOf("```");
        if (jsonStart >= "```json".Length && jsonEnd > jsonStart)
        {
            return responseText.Substring(jsonStart, jsonEnd - jsonStart).Trim();
        }
        // Fallback: If no Markdown, try to find the JSON manually
        int braceStart = responseText.IndexOf("{");
        int braceEnd = responseText.LastIndexOf("}");
        if (braceStart >= 0 && braceEnd > braceStart)
        {
            return responseText.Substring(braceStart, braceEnd - braceStart + 1).Trim();
        }
        throw new InvalidOperationException("No valid JSON found in the response.");
    }

    public async Task<FitnessPlan> GenerateFitnessPlanAsync(string prmpt)
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
        var jsonText = ExtractJsonFromResponse(planText);
        var jsonResponse = JsonSerializer.Deserialize<FitnessPlan>(jsonText);

        //var modelResponse = _parser.Parse(planText);
        return jsonResponse;

    }
}

public class OllamaResponse
{
    [JsonPropertyName("model")]
    public string Model { get; set; }
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }
    [JsonPropertyName("response")]
    public string Response { get; set; }
    [JsonPropertyName("done")]
    public bool Done { get; set; }
    [JsonPropertyName("context")]
    public long[] Context { get; set; }
    [JsonPropertyName("totla_duration")]
    public long TotalDuration { get; set; }
    [JsonPropertyName("load_duration")]
    public long LoadDuration { get; set; }
    [JsonPropertyName("prompt_eval_count")]
    public int PromptEvalCount { get; set; }
    [JsonPropertyName("eval_count")]
    public int EvalCount { get; set; }
    [JsonPropertyName("eval_duration")]
    public long EvalDuration { get; set; }
}

public class GrokPlanParser()
{
    public FitnessPlan Parse(string response)
    {
        var plan = new FitnessPlan
        {
            WarmUp = new List<WarmUpCoolDownExercise>(),
            CoolDown = new List<WarmUpCoolDownExercise>(),
            Weeks = new List<Week>(),
            RecoveryTips = new List<string>()
        };

        var lines = response.Split('\n').Select(l => l.Trim()).ToList();
        int index = 0;

        // parse warm-up
        if (lines[index].StartsWith("**Warm-up:**"))
        {
            index++;
            while (index < lines.Count && lines[index].StartsWith("- "))
            {
                var parts = lines[index].Substring(2).Split(": ");
                plan.WarmUp.Add(new WarmUpCoolDownExercise
                {
                    Exercise = parts[0].Trim(),
                    Description = parts.Length > 1 ? parts[1].Trim() : ""
                });
                index++;
            }
        }

        // parse Warm-up
        if (lines[index].StartsWith("**Cool-down:**"))
        {
            index++;
            while (index < lines.Count && lines[index].StartsWith("- "))
            {
                var parts = lines[index].Substring(2).Split(": ");
                plan.WarmUp.Add(new WarmUpCoolDownExercise
                {
                    Exercise = parts[0].Trim(),
                    Description = parts.Length > 1 ? parts[1].Trim() : ""
                });
                index++;
            }
        }

        // parse Weeks
        while (index < lines.Count && lines[index].StartsWith("* Week "))
        {
            var week = new Week
            {
                WeekNumber = int.Parse(lines[index].Substring(7).Trim()),
                Days = new List<Day>()
            };

            index++;
            while (index < lines.Count && lines[index].StartsWith("- Day "))
            {
                var day = new Day
                {
                    DayNumber = int.Parse(lines[index].Substring(6).Trim()),
                    Exercises = new List<GrokExercise>()
                };

                index++;
                while (index < lines.Count && lines[index].StartsWith("+ "))
                {
                    var exerciseLine = lines[index].Substring(2).Split(": ");
                    var setsReps = exerciseLine[1].Trim().Split(" x ");
                    day.Exercises.Add(new GrokExercise
                    {
                        Name = exerciseLine[0].Trim(),
                        Sets = int.Parse(setsReps[0].Replace("sets", "").Trim()),
                        Reps = int.Parse(setsReps[1].Replace("reps", "").Trim()),
                    });
                    index++;
                }
                week.Days.Add(day);
            }
            plan.Weeks.Add(week);
        }

        // Parse Recovery Tips
        if (index < lines.Count && lines[index].StartsWith("**Tips for recovery:**"))
        {
            index++;
            while (index < lines.Count && lines[index].StartsWith("- "))
            {
                plan.RecoveryTips.Add(lines[index].Substring(2).Trim());
                index++;
            }
        }

        return plan;


    }
}

public class FitnessPlan
{
    public List<WarmUpCoolDownExercise> WarmUp { get; set; }
    public List<WarmUpCoolDownExercise> CoolDown { get; set; }
    public List<Week> Weeks { get; set; }
    public List<string> RecoveryTips { get; set; }
}

public class WarmUpCoolDownExercise
{
    public string Exercise { get; set; }
    public string Description { get; set; }
}

public class Week
{
    public int WeekNumber { get; set; }
    public List<Day> Days { get; set; }
}

public class Day
{
    public int DayNumber { get; set; }
    public List<GrokExercise> Exercises { get; set; }
}

public class GrokExercise 
{
    public string Name { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
}
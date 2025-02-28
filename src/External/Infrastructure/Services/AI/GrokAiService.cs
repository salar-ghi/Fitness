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

    public GrokAiService(IHttpClientFactory httpClient, IOllamaApiClient ollama)
    {
        _httpClient = httpClient.CreateClient("OllamaClient");
        _parser = new GrokPlanParser();
        _ollama = ollama;
    }


    public FitnessPlan ParseFitnessPlan(string jsonResponse)
    {
        return JsonSerializer.Deserialize<FitnessPlan>(jsonResponse);
    }

    

    public async Task<FitnessPlan> GenerateFitnessPlanAsync(string prmpt)
    {
        var aiPrompt = prmpt;

        //var response1 = await _ollama.GenerateAsync(aiPrompt).StreamToEndAsync().ConfigureAwait(false);

        var request = new
        {
            model = "llama3.1:latest",
            prompt = aiPrompt,
        };
        var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");

        //_httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(300) };
        var response = await _httpClient.PostAsync("/api/generate", content);
            //new StringContent(JsonSerializer.Serialize(new { prompt = aiPrompt }), Encoding.UTF8, "application/json"));

        var responseText = await response.Content.ReadAsStringAsync();
        var ollamaResponse = JsonSerializer.Deserialize<Dictionary<string, string>>(responseText);
        var planText = ollamaResponse["response"];

        var jsonResponse = ParseFitnessPlan(planText);


        //var modelResponse = _parser.Parse(planText);

        return jsonResponse;

    }
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
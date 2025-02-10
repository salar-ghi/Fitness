using Infrastructure.Models;
using Infrastructure.Services.PlanParser;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Infrastructure.Services.AI;

public class OpenAiChatService //: IOpenAiChatService
{
    private readonly HttpClient _httpClient;
    private readonly IFitnessPlanParser _parser;
    private readonly IPlanParser _planParser;
    public OpenAiChatService(HttpClient httpClient, IFitnessPlanParser parser, IPlanParser planParser)
    {
        _httpClient = httpClient;
        _parser = parser;
        _planParser = planParser;
    }

    public async Task<FitnessPlanResponse> GetResponse(string question)
    {
        var planResponse = new FitnessPlanResponse();

        var request = new
        {
            model = "llama3.2",
            prompt = question,
            stream = false
        };

        var response = await _httpClient.PostAsJsonAsync("api/generate", request);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<OllamaResponse>();


        // Extract Warm-up/Cool-down
        planResponse.PrePostWorkout = _planParser.ExtractWarmUpCoolDown(result.Response);
            // Extract Weekly Schedules
        planResponse.WeeklySchedules = _planParser.ExtractWeeklySchedules(result.Response);


        planResponse.PrePostWorkoutRoutine = _planParser.ExtractWarmUpCoolDownRoutine(result.Response);
        planResponse.WeeklySchedulesRoutine = _planParser.ExtractWeeklySchedulesAlternative(result.Response);

        return (planResponse);
    }

    public async Task<List<Section>> GetWeekResponse(string question)
    {
        var planResponse = new FitnessPlanResponse();

        var request = new
        {
            model = "llama3.2",
            prompt = question,
            stream = false
        };

        var response = await _httpClient.PostAsJsonAsync("api/generate", request);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<OllamaResponse>();

        var weekResponse = _planParser.ExtractWeeksplan(result.Response);

        return (weekResponse);
    }
    //private record OllamaResponse(string Response);
}


public interface IFitnessPlanParser
{
    ExerciseRoutine ExtractRoutine(string responseText);
    FitnessPlanResponse Parse(string responseText);
}

public class FitnessPlanParser : IFitnessPlanParser
{
    public FitnessPlanResponse Parse(string responseText)
    {
        var result = new FitnessPlanResponse();
        return result;
    }

    private List<string> ExtractWarmUpCoolDown(string text)
    {
        var warmupsections = new List<string>();
        var warmUpMatch = Regex.Match(text, @"\*\*Warm-up and Cool-down Routines:\*\*([\s\S]*?)(\*\*Weeks|\*\*Fat Loss)", RegexOptions.IgnoreCase);

        if (warmUpMatch.Success)
        {
            var items = Regex.Matches(warmUpMatch.Groups[1].Value, @"\*\s*(.*?)\s*$", RegexOptions.Multiline);
            foreach (Match item in items)
            {
                warmupsections.Add(item.Groups[1].Value.Trim());
            }
        }
        return warmupsections;
    }


    public ExerciseRoutine ExtractRoutine(string responseText)
    {
        return new ExerciseRoutine
        {
            WarmUp = ExtractSection(responseText, "Warm-up"),
            CoolDown = ExtractSection(responseText, "Cool-down")
        };
    }


    private string ExtractSection(string text, string sectionName)
    {
        // Case-insensitive search for section patterns
        var pattern = $@"(\*+|#+)\s*{sectionName}.*?(?:\n|$)(.*?)(?=\n\s*(\*+|#+)|$)";
        var match = Regex.Match(text, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);

        return match.Success ? CleanContent(match.Groups[2].Value) : null;
    }

    private string CleanContent(string content)
    {
        // Remove markdown formatting and extra whitespace
        return Regex.Replace(content, @"[\*#\-]", "")
                   .Trim()
                   .Replace("\n", " ");
    }


    private string ExtractTest(string text, string startMarker, string endMarker)
    {
        var startIndex = text.IndexOf(startMarker);
        if (startIndex == -1) return string.Empty;

        startIndex += startMarker.Length;

        var endIndex = !string.IsNullOrEmpty(endMarker)
            ? text.IndexOf(endMarker, startIndex)
            : text.Length;

        return endIndex == -1
            ? text[startIndex..].Trim()
            : text[startIndex..endIndex].Trim();
    }
}

//************************ Models
public class OllamaResponse
{
    [JsonPropertyName("response")]
    public string Response { get; set; }
}
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

        // Extract Warm-up/Cool-down
        //result.WarmUpCoolDown = ExtractWarmUpCoolDown(responseText);

        //// Extract Weekly Plans
        //result.WeeklyPlans = ExtractWeeklyPlans(responseText);

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

    //private List<WeekPlan> ExtractWeeklyPlans(string text)
    //{
    //    var weeklyPlans = new List<WeekPlan>();
    //    var weekMatches = Regex.Matches(text, @"\*\*Weeks (\d+-\d+): (.*?)\*\*([\s\S]*?)(?=\*\*Weeks|\*\*Fat Loss)", RegexOptions.IgnoreCase);

    //    foreach (Match weekMatch in weekMatches)
    //    {
    //        var weekPlan = new WeekPlan
    //        {
    //            WeekRange = $"Week {weekMatch.Groups[1].Value}",
    //            Days = ExtractDays(weekMatch.Groups[3].Value)
    //        };
    //        weeklyPlans.Add(weekPlan);
    //    }
    //    return weeklyPlans;
    //}

    //private List<DaySchedule> ExtractDays(string weekContent)
    //{
    //    var days = new List<DaySchedule>();
    //    var dayMatches = Regex.Matches(weekContent, @"\+\s*(.*?)\s*:([\s\S]*?)(?=\+|\* Sets)", RegexOptions.IgnoreCase);

    //    foreach (Match dayMatch in dayMatches)
    //    {
    //        var daySchedule = new DaySchedule
    //        {
    //            DayName = dayMatch.Groups[1].Value.Trim(),
    //            Exercises = ExtractExercises(dayMatch.Groups[2].Value)
    //        };
    //        days.Add(daySchedule);
    //    }
    //    return days;
    //}

    //private List<Exercise> ExtractExercises(string dayContent)
    //{
    //    var exercises = new List<Exercise>();
    //    var exerciseMatches = Regex.Matches(dayContent, @"-\s*(.*?)\s*\((.*?)\)", RegexOptions.IgnoreCase);

    //    foreach (Match exMatch in exerciseMatches)
    //    {
    //        var exercise = new Exercise
    //        {
    //            Name = exMatch.Groups[1].Value.Trim(),
    //        };

    //        var details = exMatch.Groups[2].Value;
    //        var setMatch = Regex.Match(details, @"(\d+)\s*sets\s*of\s*(\d+[\+\-]*\d*)\s*reps");
    //        var restMatch = Regex.Match(details, @"rest\s*for\s*(\d+\s*seconds)");

    //        if (setMatch.Success)
    //        {
    //            exercise.Sets = int.Parse(setMatch.Groups[1].Value);
    //            exercise.Reps = setMatch.Groups[2].Value;
    //        }

    //        if (restMatch.Success)
    //        {
    //            exercise.RestBetweenSets = restMatch.Groups[1].Value;
    //        }

    //        exercises.Add(exercise);
    //    }
    //    return exercises;
    //}


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

public class ApiResponse
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public string Tokens { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

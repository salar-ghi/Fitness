using HtmlAgilityPack;
using Presentation.JsonSeedStorage;

namespace Presentation.JsonMappedSeedStorage;


public interface IScraperService
{
    Task ScrapeInstruction();
}

public class ScraperService : IScraperService
{
    private readonly HttpClient _httpClient;
    private readonly IWebHostEnvironment _env;
    private const string BaseUrl = "https://musclewiki.com/exercise";
    
    //private readonly HtmlWeb _htmlWeb;
    //private readonly TimeSpan _requestDelay = TimeSpan.FromSeconds(1); 


    public ScraperService(IHttpClientFactory clientFactory, IWebHostEnvironment env)
    {
        _httpClient = clientFactory.CreateClient();
        //_httpClient.DefaultRequestHeaders.UserAgent.ParseAdd();
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
        //_htmlWeb = new HtmlWeb();
        _env = env;
    }


    public async Task ScrapeInstruction()
    {
        string inputFilePath = "";
        var jsonFilePath = Path.Combine(_env.ContentRootPath, "JsonMappedSeedStorage", "WorkoutFiles", "Chest_Mid_LowerChest_UpperPectoralis.json");

        string jsonFile = await File.ReadAllTextAsync(jsonFilePath);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var workouts = JsonSerializer.Deserialize<List<WorkoutOutput>>(jsonFile, options);


        foreach(var workout in workouts)
        {
            string? primaryMuscle = workout.Muscles
                .FirstOrDefault(m => string.Equals(m.Value.MuscleTargetLevel, "Primary", StringComparison.OrdinalIgnoreCase))
                .Key;

            if (string.IsNullOrEmpty(primaryMuscle))
            {
                // Skip or log error if no primary muscle.
                continue;
            }

            workout.Instruction = await GetInstructionsAsync(workout.WorkoutName, workout.Equipment, primaryMuscle);
            await Task.Delay(2000);
        }
        Console.Clear();
        Console.WriteLine(workouts);
        //string updatedJson = JsonSerializer.Serialize(workouts, new JsonSerializerOptions { WriteIndented = true });
        //await System.IO.File.WriteAllTextAsync(outputFilePath, updatedJson);
    }


    private async Task<Dictionary<string, string>> GetInstructionsAsync(string workoutName, string equipment, string primaryMuscle)
    {
        var instructions = new Dictionary<string, string>();
        try
        {
            string equipmentSlug = equipment.ToLowerInvariant();
            string muscleSlug = primaryMuscle.ToLowerInvariant();
            string workoutSlug = workoutName.ToLowerInvariant().Replace(" ", "-").Replace("'", "").Replace(".", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace("/", "-"); // Clean slug (add more replacements if needed).

            //string url = $"https://musclewiki.com/exercise/{equipmentSlug}/male/{muscleSlug}/{workoutSlug}";
            string url = $"{BaseUrl}/{equipmentSlug}/male/{muscleSlug}/{workoutSlug}";
            string html = await _httpClient.GetStringAsync(url);

            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var dlNode = doc.DocumentNode
                .SelectSingleNode("//div[contains(@class, 'sm:pb-5 mt-5 relative')]//dl[contains(@class, 'my-5 grid') and contains(@class, 'gap-x-6') and contains(@class, 'gap-y-4')]");


            if (dlNode != null)
            {
                // Select child divs for each step.
                var stepDivs = dlNode.SelectNodes(".//div[contains(@class, 'border-gray-200') and contains(@class, 'flex') and contains(@class, 'items-center')]");

                if (stepDivs != null)
                {
                    foreach (var stepDiv in stepDivs)
                    {
                        // Get step number from button inside dt.
                        var buttonNode = stepDiv.SelectSingleNode(".//dt//button[contains(@class, 'rounded-full') and contains(@class, 'bg-gradient-to-r')]");
                        string stepNumber = buttonNode?.InnerText.Trim() ?? "Unknown";

                        // Get instruction text from dd.
                        var ddNode = stepDiv.SelectSingleNode(".//dd[contains(@class, 'text-gray-500') and contains(@class, 'bg-white')]");
                        string stepText = ddNode?.InnerText.Trim() ?? "";

                        if (!string.IsNullOrEmpty(stepNumber) && !string.IsNullOrEmpty(stepText))
                        {
                            instructions[stepNumber] = stepText;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Log error (e.g., via ILogger); handle 404 or parsing failures.
            Console.WriteLine($"Error scraping {workoutName}: {ex.Message}");
        }
        return instructions;



    }
}

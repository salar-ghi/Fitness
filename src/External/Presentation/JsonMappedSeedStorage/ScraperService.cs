using Azure;
using HtmlAgilityPack;
using Presentation.JsonSeedStorage;
using PuppeteerSharp;

namespace Presentation.JsonMappedSeedStorage;


public interface IScraperService
{
    Task<string> ScrapeInstruction();
}

public class ScraperService : IScraperService
{
    private readonly HttpClient _httpClient;
    private readonly IWebHostEnvironment _env;
    private const string BaseUrl = "https://musclewiki.com/exercise";
    private readonly HtmlWeb _htmlWeb;

    public ScraperService(IHttpClientFactory clientFactory, IWebHostEnvironment env)
    {
        _httpClient = clientFactory.CreateClient();
        //_httpClient.DefaultRequestHeaders.UserAgent.ParseAdd();
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
        _htmlWeb = new HtmlWeb();
        _env = env;
    }


    public async Task<string> ScrapeInstruction()
    {
        var jsonFilePath = Path.Combine(_env.ContentRootPath, "JsonMappedSeedStorage", "WorkoutFiles", "Traps(mid-back)_LowerBack_Lats_Traps_UpperTraps_LowerTraps.json");

        string jsonFile = await File.ReadAllTextAsync(jsonFilePath);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var workouts = JsonSerializer.Deserialize<List<WorkoutOutput>>(jsonFile, options);

        foreach(var workout in workouts)
        {
            string? primaryMuscle = workout.Muscles
                .FirstOrDefault(m => string.Equals(m.Value.MuscleTargetLevel, "Primary", StringComparison.OrdinalIgnoreCase))
                .Key;

            if (string.IsNullOrEmpty(primaryMuscle))
                continue;

            workout.Instruction = await GetInstructionsAsync(workout.WorkoutName, workout.Equipment, primaryMuscle);
            await Task.Delay(8000);
        }
        Console.Clear();
        Console.WriteLine(workouts);


        string outputJson = JsonSerializer.Serialize(workouts, new JsonSerializerOptions { WriteIndented = true });
        string outputFolderPath = Path.Combine(_env.ContentRootPath, "JsonMappedSeedStorage");
        string filePath = Path.Combine(outputFolderPath, "WorkoutUpdateInstructionFiles", "Traps(mid-back)_LowerBack_Lats_Traps_UpperTraps_LowerTraps.json");
        //if (!File.Exists(outputFolderPath))
        //{
        //    Directory.CreateDirectory(outputFolderPath);
        //}
        await File.WriteAllTextAsync(filePath, outputJson);


        return "Eyval";
    }


    private async Task<Dictionary<string, string>> GetInstructionsAsync(string workoutName, string equipment, string primaryMuscle)
    {
        var instructions = new Dictionary<string, string>();
        //var instructions = new List<string>();
        int stepCount = 1;
        try
        {
            string equipmentSlug = equipment.ToLowerInvariant();
            string muscleSlug = primaryMuscle.ToLowerInvariant();
            string workoutSlug = workoutName.ToLowerInvariant().Replace(" ", "-").Replace("'", "").Replace(".", "").Replace("(", "").Replace(")", "").Replace("/", "-");

            //await new BrowserFetcher().DownloadAsync();
            var launchOptions = new LaunchOptions
            {
                Headless = true,
                Args = new[] { "--no-sandbox", "--disable-setuid-sandbox" },
                ExecutablePath = @"C:\chrome-win64\chrome.exe",
            };
            await using var browser = await Puppeteer.LaunchAsync(launchOptions);
            await using var page = await browser.NewPageAsync();

            await page.SetUserAgentAsync("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
            string url = $"{BaseUrl}/{equipmentSlug}/male/{muscleSlug}/{workoutSlug}";

            await page.GoToAsync(url, WaitUntilNavigation.Networkidle2);
            //await page.GoToAsync(url, new NavigationOptions { WaitUntil = new[] { WaitUntilNavigation.Networkidle2 }, Timeout = 60000 });
            await page.WaitForSelectorAsync("dl.my-5.grid", new WaitForSelectorOptions { Timeout = 7000 });

            string html = await page.GetContentAsync();
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            while (true)
            {
                var instructionNode = doc.DocumentNode.SelectSingleNode(
                    $"//div[contains(@class, 'sm:pb-5')]//dt[contains(@class, 'font-medium') and contains(., '{stepCount}')]" +
                    "/following-sibling::dd[1]");

                if (instructionNode == null) break;
                var num = stepCount.ToString().Trim();
                instructions[num] = instructionNode.InnerText.Trim().ToString();
                stepCount++;
                num = string.Empty;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error scraping {workoutName}: {ex.Message}");
        }
        return instructions;
    }
}

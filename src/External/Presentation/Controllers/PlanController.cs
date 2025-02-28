using Azure;
using Domain.Models;
using Infrastructure.Services.AI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using SharpToken;
using System.Net.Http.Json;
using static System.Net.Mime.MediaTypeNames;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlanController : ControllerBase
{
    private readonly IPlanManagingService _planManaging;
    private readonly IGrokAiService _grokService;
    //private readonly OpenAiChatService _ollama;
    //private readonly ApiContext _context;
    private readonly ILogger<PlanController> _logger;

    public PlanController(
        IPlanManagingService planManaging, 
        //OpenAiChatService ollama,
        IGrokAiService grokService,
        ILogger<PlanController> logger)
    {
        _planManaging = planManaging;
        //_ollama = ollama;
        _logger = logger;
        _grokService = grokService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var question = PromtPlan();
        //var response = await _ollama.GetResponse(question);
        //var response = await _ollama.GetWeekResponse(question);

        return Ok();

    }


    [HttpGet("Generate")]
    public async Task<IActionResult> GeneratePlan()
    {
        var prompt = RefinedJsonPrompt();
        var plan = await _grokService.GenerateFitnessPlanAsync(prompt);
        return Ok(plan);
    }

    [HttpGet("Generate-AI")]
    public async Task<IActionResult> GeneratePlanAI()
    {
        return Ok();
    }

    protected static string PromtPlan()
    {
        var aiPrompt = $"Create a detailed 16-week fitness plan for a 31-year-old male beginner with the following details:" +
            $"" +
            $"Body Stats: 170 cm height, 92 kg weight, endomorph body type." +
            $"Injuries: Leg injuries(avoid exercises that aggravate the legs." +
            $"Goals: Fat loss, target weight of 70 kg, and a muscular physique with a focus on chest, back, and shoulders." +
            $"Equipment: Dumbbells, Smith machine, bodyweight exercises, and resistance bands(gym setting)." +
            $"Schedule: 4 days per week, 60 minutes per session." +
            $"" +
            $"Structure the response EXACTLY as follows:" +
            $"" +
            $"1. Warm-up: Provide a list of warm-up exercises, including duration or repetitions." +
            $"2. Cool-down: Provide a list of cool-down exercises, including duration or repetitions." +
            $"3. Weekly Schedules: For each week, include:" +
            $"      (* Week X): Break down each week into daily schedules." +
            $"          For each day '- Day 1, - Day 2' " +
            $"              list: + Exercises with sets and repetitions." +
            $"4. Tips for recovery: Include stretching and hydration." +
            $"" +
            $"Format all weeks schedule with 1 asteriks before and a number after week for example '* Week 1' " +
            $"Format all days using this (-) symbol before for example '- Day 1' and before this sign (-) do not set any other sign" +
            $"Format all exercises using the symbol (+) before for example '+ Exercise 1' as shown above. " +
            $"and in weekly schedule just mention once week name or once mention day X and do not mention warm-up or cool-down more than once in each week schedule " +
            $"then go to next week schedule and Days under that week and totatlly avoid from repeating days number or week number";

        //$"4.Fat-loss strategies: such as incorporating cardio or HIIT in a safe manner." +
        return aiPrompt;
    }


    protected static string RefinedPrompt()
    {
        var aiPrompt = $"Create a detailed 16-week fitness plan for a 31-year-old male beginner with the following details: " +
            $"Body Stats: 170 cm height, 92 kg weight, endomorph body type. " +
            $"Injuries: Leg injuries (avoid exercises that aggravate the legs). " +
            $"Goals: Fat loss, target weight of 70 kg, and a muscular physique with a focus on chest, back, and shoulders. " +
            $"Equipment: Dumbbells, Smith machine, bodyweight exercises, and resistance bands (gym setting). " +
            $"Schedule: 4 days per week, 60 minutes per session. " +
            $"\n" +
            $"Structure the response EXACTLY as follows: " +
            $"\n" +
            $"**Warm-up:** " +
            $"Provide a list of warm-up exercises, each on a new line, with duration or repetitions. Use this format: " +
            $"- Exercise Name: description (e.g., duration or reps). " +
            $"Example: " +
            $"- Arm Circles: 30 seconds " +
            $"- Torso Twists: 20 reps " +
            $"\n" +
            $"**Cool-down:** " +
            $"Provide a list of cool-down exercises, each on a new line, with duration or repetitions. Use this format: " +
            $"- Exercise Name: description (e.g., duration or reps). " +
            $"Example: " +
            $"- Chest Stretch: 30 seconds " +
            $"- Shoulder Stretch: 30 seconds " +
            $"\n" +
            $"Then, for each of the 16 weeks, provide the following: " +
            $"* Week X (where X is the week number from 1 to 16, listed only once per week) " +
            $"  - Day 1 " +
            $"    + Exercise Name: sets x reps " +
            $"    + Exercise Name: sets x reps " +
            $"  - Day 2 " +
            $"    + Exercise Name: sets x reps " +
            $"    + Exercise Name: sets x reps " +
            $"  - Day 3 " +
            $"    + Exercise Name: sets x reps " +
            $"    + Exercise Name: sets x reps " +
            $"  - Day 4 " +
            $"    + Exercise Name: sets x reps " +
            $"    + Exercise Name: sets x reps " +
            $"\n" +
            $"**Tips for recovery:** " +
            $"Provide a list of tips, each on a new line, using this format: " +
            $"- Tip description " +
            $"Example: " +
            $"- Stretch after each workout " +
            $"- Drink 2 liters of water daily " +
            $"\n" +
            $"Rules: " +
            $"- Use EXACTLY these symbols: ** for section headers (Warm-up, Cool-down, Tips for recovery), * for week numbers, - for days and list items, + for exercises. " +
            $"- Do NOT use any other symbols (e.g., no ** for days, no # anywhere). " +
            $"- List warm-up and cool-down ONLY once at the beginning, NOT within weekly schedules. " +
            $"- Do NOT repeat week numbers or day numbers (e.g., mention '* Week 1' only once per week). " +
            $"- Ensure each week has exactly 4 days, labeled - Day 1 to - Day 4. " +
            $"- Ensure exercises suit the equipment and avoid aggravating leg injuries.";

        return aiPrompt;
    }


    protected static string RefinedJsonPrompt()
    {
        var aiPrompt = $"Create a detailed 16-week fitness plan for a 31-year-old male beginner with the following details: " +
            $"Body Stats: 170 cm height, 92 kg weight, endomorph body type. " +
            $"Injuries: Leg injuries (avoid exercises that aggravate the legs). " +
            $"Goals: Fat loss, target weight of 70 kg, and a muscular physique with a focus on chest, back, and shoulders. " +
            $"Equipment: Dumbbells, Smith machine, bodyweight exercises, and resistance bands (gym setting). " +
            $"Schedule: 4 days per week, 60 minutes per session. " +
            $"\n" +
            $"Provide the response in JSON format with this exact structure: " +
            $"{{\n" +
            $"  \"warm_up\": [\n" +
            $"    {{ \"exercise\": \"Exercise Name\", \"description\": \"duration or reps\" }},\n" +
            $"    {{ \"exercise\": \"Exercise Name\", \"description\": \"duration or reps\" }}\n" +
            $"  ],\n" +
            $"  \"cool_down\": [\n" +
            $"    {{ \"exercise\": \"Exercise Name\", \"description\": \"duration or reps\" }},\n" +
            $"    {{ \"exercise\": \"Exercise Name\", \"description\": \"duration or reps\" }}\n" +
            $"  ],\n" +
            $"  \"weeks\": [\n" +
            $"    {{\n" +
            $"      \"week_number\": 1,\n" +
            $"      \"days\": [\n" +
            $"        {{\n" +
            $"          \"day_number\": 1,\n" +
            $"          \"exercises\": [\n" +
            $"            {{ \"name\": \"Exercise Name\", \"sets\": 3, \"reps\": 12 }},\n" +
            $"            {{ \"name\": \"Exercise Name\", \"sets\": 3, \"reps\": 10 }}\n" +
            $"          ]\n" +
            $"        }},\n" +
            $"        {{ \"day_number\": 2, \"exercises\": [...] }},\n" +
            $"        {{ \"day_number\": 3, \"exercises\": [...] }},\n" +
            $"        {{ \"day_number\": 4, \"exercises\": [...] }}\n" +
            $"      ]\n" +
            $"    }},\n" +
            $"    {{ \"week_number\": 2, \"days\": [...] }},\n" +
            $"    ...\n" +
            $"  ],\n" +
            $"  \"recovery_tips\": [\n" +
            $"    \"Tip 1\",\n" +
            $"    \"Tip 2\"\n" +
            $"  ]\n" +
            $"}}\n" +
            $"Ensure exercises suit the equipment and avoid aggravating leg injuries.";
        return aiPrompt;
    }
}

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

    private readonly OpenAiChatService _ollama;
    //private readonly ApiContext _context;
    private readonly ILogger<PlanController> _logger;

    public PlanController(IPlanManagingService planManaging, OpenAiChatService ollama, ILogger<PlanController> logger)
    {
        _planManaging = planManaging;
        _ollama = ollama;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var question = PromtPlan();
        //var response = await _ollama.GetResponse(question);
        var response = await _ollama.GetWeekResponse(question);

        return Ok(new { response });

    }


    [HttpGet("Generate")]
    public async Task<IActionResult> GeneratePlan()
    {
        return Ok();
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
            $"Body Stats: 170 cm height, 89 kg weight, endomorph body type." +
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

}

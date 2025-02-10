using Infrastructure.Services.AI;
using Microsoft.AspNetCore.Mvc;
using SharpToken;
using System.Net.Http.Json;

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
        //var tokens = Tokenize(response);
        //var sharpTokens = SharpTokenize(response);

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
        var aiGeneratedPrompt = $"Create a detailed 16-week fitness plan for a 31-year-old male beginner with the following details:" +
            $"Body Stats: 170 cm height, 89 kg weight, endomorph body type." +
            $"Injuries: Leg injuries(avoid exercises that aggravate the legs)." +
            $"Goals: Fat loss, target weight of 70 kg, and a muscular physique with a focus on chest, back, and shoulders." +
            $"Equipment: Dumbbells, Smith machine, bodyweight exercises, and resistance bands(gym setting)." +
            $"Schedule: 4 days per week, 45 minutes per session." +
            $"Include the following in the plan:" +
            $"Warm - up and cool-down routines to prevent injury and improve mobility." +
            $"Progressive overload to ensure steady progress." +
            $"Low - impact leg exercises that do not aggravate leg injuries." +
            $"Targeted exercises for chest, back, and shoulders." +
            $"Fat - loss strategies such as incorporating cardio or HIIT in a safe manner." +
            $"Weekly breakdown of workouts, including sets, reps, and rest periods." +
            $"Tips for recovery, including stretching and hydration." +
            $"Ensure the plan is beginner - friendly, safe for someone with leg injuries, and tailored to an endomorph body type for optimal fat loss and muscle building.";

        return aiGeneratedPrompt;
    }



    private List<string> Tokenize(string text)
    {
        // Simple whitespace tokenizer - replace with proper tokenization if needed
        return text.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }
    private List<string> SharpTokenize(string text)
    {
        var encoding = GptEncoding.GetEncoding("cl100k_base");
        var tokens = encoding.Encode(text);
        return tokens.Select(t => t.ToString()).ToList();
    }
}

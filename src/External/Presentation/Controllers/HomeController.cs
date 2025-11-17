namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly IChatService _chatService;
    private readonly IPlanManagingService _planManagingService;
    private readonly Ollama _ollama;

    public HomeController(IChatService chatService, IPlanManagingService planManagingService)
    {
        _chatService = chatService;
        _planManagingService = planManagingService;
    }

    //[HttpGet]
    [HttpPost]
    public async Task<IActionResult> Index([FromBody] string question)
    {
        //var response = await _chatService.AskQuestionAsync(question);
        return Ok();
    }

    [HttpPost("AskQuestion")]
    public async Task<IActionResult> AskQuestion()
    {
        var promt = Promt();
        var response = await _chatService.AskQuestion(promt);

        //var parsedResponse = await _ollama.ParseResponseAsync(response);
        //var formattedTable = _ollama.FormatResponseAsTable(parsedResponse);

        return Ok(response);
    }

    [HttpGet("GenerateApp")]
    public async Task<IActionResult> GenerateApp()
    {
        var promt = Promt();
        var response = _chatService.AskQuestionDeepSeekAsync(promt);
        return Ok(response);
    }

    protected static string Promt()
    {
        var aiGeneratedPrompt = $"Create a detailed 16-week fitness plan for a 31-year-old female beginner with the following details:" +
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


}

using Presentation.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkoutController : ControllerBase
{
    private readonly WorkoutDatasets workoutDatasets;
    private readonly GrokService _grokService;
    private readonly OpenAiService _openAiService;
    private readonly IDeepSeekService _deepSeekService;
    public WorkoutController(WorkoutDatasets _workoutDatasets, 
        GrokService grokService, 
        OpenAiService openAiService,
        IDeepSeekService deepSeekService)
    {
        workoutDatasets = _workoutDatasets;
        _grokService = grokService;
        _openAiService = openAiService;
        _deepSeekService = deepSeekService;
    }


    [HttpGet("workout duplication")]
    public async Task<IActionResult> IndexWorkouts()
    {
        var dataSet = await workoutDatasets.WorkoutSeedAsync();


        return Ok(dataSet);
    }

    [HttpGet("ask")]
    public async Task<IActionResult> AskQuestion()
    {
        var result = new List<string>();
        var dataSet = await workoutDatasets.WorkoutSeedAsync();
        foreach (var item in dataSet)
        {
            var name = item.Name;
            var instruction = $"in bodybuiding describe the instructions of doing {item.Name} between 2 to 6 steps and mention the level of this exercise";
            //var response  = await _grokService.AskQuestionAsync(instruction);
            //var response  = await _openAiService.AskQuestionAsync(instruction);
            var response  = await _deepSeekService.GetResponseAsync(instruction);
            Console.Clear();
            Console.WriteLine(response);
            result.Add(response);
        }
        return Ok(result);
    }
}

using Presentation.JsonMappedSeedStorage;
using Presentation.JsonSeedStorage;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkoutController : ControllerBase
{
    private readonly IExerciseMapperService _mapService;
    private readonly IGenerateCodeService _generateCodeService;
    private readonly IScraperService _scraperService;
    private readonly IScrapeInstructionService _scrapeInstructionService;
    //private readonly WorkoutDatasets workoutDatasets;

    //public WorkoutController(WorkoutDatasets _workoutDatasets)
    //{
    //    workoutDatasets = _workoutDatasets;
    //}

    public WorkoutController(IExerciseMapperService mapService, 
        IGenerateCodeService generateCodeService, IScraperService scraperService
        , IScrapeInstructionService scrapeInstructionService)
    {
        _mapService = mapService;
        _generateCodeService = generateCodeService;
        _scraperService = scraperService;
        _scrapeInstructionService = scrapeInstructionService;
    }

    [HttpGet("workout duplication")]
    public async Task<IActionResult> IndexWorkouts()
    {
        //var dataSet = await workoutDatasets.WorkoutSeedAsync();
        await WorkoutDatasets.duplicateWorkouts();
        return Ok();
    }


    [HttpGet("workout map")]
    public async Task<IActionResult> MapExercises()
    {
        await _mapService.ProcessAndSaveExercisesAsync();
        return Ok();
    }


    [HttpGet("Generate Code")]
    public async Task<IActionResult> GenerateCode()
    {
        await _generateCodeService.GenerateCodeInitializer();
        return Ok();
    }


    [HttpGet("scrape-instructions")]
    public async Task<IActionResult> ScrapeInstructions()
    {
        var result = await _scraperService.ScrapeInstruction();
        return Ok(result);
    }


    [HttpGet("scrape-instruction-total")]
    public async Task<IActionResult> ScrapeInstructionsTotal()
    {
        var result = await _scrapeInstructionService.ScrapeTotalInstruction();
        return Ok(result);
    }




}

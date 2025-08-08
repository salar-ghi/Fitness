using Presentation.JsonSeedStorage;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkoutController : ControllerBase
{
    private readonly IExerciseMapperService _mapService;
    //private readonly WorkoutDatasets workoutDatasets;

    //public WorkoutController(WorkoutDatasets _workoutDatasets)
    //{
    //    workoutDatasets = _workoutDatasets;
    //}

    public WorkoutController(IExerciseMapperService mapService)
    {
        _mapService = mapService;
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


}

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkoutController : ControllerBase
{
    private readonly WorkoutDatasets workoutDatasets;
    public WorkoutController(WorkoutDatasets _workoutDatasets)
    {
        workoutDatasets = _workoutDatasets;
    }


    [HttpGet("workout duplication")]
    public async Task<IActionResult> IndexWorkouts()
    {
        var dataSet = await workoutDatasets.WorkoutSeedAsync();

        return Ok(dataSet);
    }
}

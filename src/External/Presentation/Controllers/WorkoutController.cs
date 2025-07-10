using Presentation.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkoutController : ControllerBase
{
    //private readonly WorkoutDatasets workoutDatasets;

    //public WorkoutController(WorkoutDatasets _workoutDatasets)
    //{
    //    workoutDatasets = _workoutDatasets;
    //}

    public WorkoutController()
    {
        
    }

    [HttpGet("workout duplication")]
    public async Task<IActionResult> IndexWorkouts()
    {
        //var dataSet = await workoutDatasets.WorkoutSeedAsync();
        await WorkoutDatasets.duplicateWorkouts();
        return Ok();
    }


}

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlanController : ControllerBase
{
    private readonly IPlanManagingService _planManaging;
    private readonly ILogger<PlanController> _logger;

    public PlanController(IPlanManagingService planManaging, ILogger<PlanController> logger)
    {
        _planManaging = planManaging;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Index([FromBody] RegisterDto dto)
    {

        return Ok();
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

}

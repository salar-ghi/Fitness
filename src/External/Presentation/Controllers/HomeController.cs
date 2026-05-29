namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
 
    private readonly IPlanManagingService _planManagingService;
    public HomeController(
        IPlanManagingService planManagingService)
    {
        _planManagingService = planManagingService;        
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var plan = await _planManagingService.TestPlanProcessingTask();
        return Ok(plan);
    }
}

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlanController : ControllerBase
{


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

}

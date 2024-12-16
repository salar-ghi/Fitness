namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly IChatService _chatService;

    public HomeController(IChatService chatService)
    {
        _chatService = chatService;
    }

    //[HttpGet]
    [HttpPost]
    public async Task<IActionResult> Index([FromBody] string question)
    {
        var response = await _chatService.AskQuestionAsync(question);
        return Ok(response);
    }


}

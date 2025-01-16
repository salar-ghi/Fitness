namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly IChatService _chatService;
    private readonly Ollama _ollama;

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


    public async Task<IActionResult> AskQuestion([FromBody] string question)
    {
        var response = await _chatService.AskQuestion(question);
        var parsedResponse = await _ollama.ParseResponseAsync(response);
        var formattedTable = _ollama.FormatResponseAsTable(parsedResponse);

        return Ok(formattedTable);
    }


}

using Application.DTOs;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    #region Definition and Ctor

    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IConfiguration _config;
    
    public AuthController(
        UserManager<User> userManager, 
        SignInManager<User> signInManager, 
        IConfiguration config)
    {
        _userManager = userManager;
        _signInManager = signInManager;

        _config = config;
    }

    #endregion

    #region Classes and Methods

    [HttpPost("Register")]
    public async Task<IActionResult> Register()
    {
        return Ok();
    }


    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        var user = await _userManager.FindByNameAsync(dto.Phonenum);
    }

    #endregion 




}

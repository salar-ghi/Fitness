using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok("that's it ");
        }


    }
}

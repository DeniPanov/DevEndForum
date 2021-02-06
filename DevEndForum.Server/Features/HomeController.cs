namespace DevEndForum.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("controller")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("It works!");
        }
    }
}

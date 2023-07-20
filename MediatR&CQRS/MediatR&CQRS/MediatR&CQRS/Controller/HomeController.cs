using Microsoft.AspNetCore.Mvc;

namespace MediatRCQRS.Controller
{
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WordTreasury.api
{
    public class Monitoring : Controller
    {
        [HttpGet]
        [Route("api/monitoring")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

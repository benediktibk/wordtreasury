using Microsoft.AspNetCore.Mvc;
using WordTreasury.dto;

namespace WordTreasury.api
{
    public class Authentication : Controller
    {
        [HttpGet]
        [Route("api/authentication/login")]
        public string Post([FromBody] Login login)
        {
            return "token";
        }
        
        [Route("api/authentication/logout")]
        public IActionResult Post([FromBody] Logout login)
        {
            return Ok();
        }
    }
}

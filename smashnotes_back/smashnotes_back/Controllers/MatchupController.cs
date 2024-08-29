using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace smashnotes_back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MatchupController : ControllerBase
    {
        [HttpGet(Name = "GetMatchup")]
        public string Get()
        {
            return "asdsa";
        }

    }
}

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
            return "Re-envio de data 11111";

            return "Re-envio de data";
        }




    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static smashnotes_back.Controllers.Matchup2Controller;

namespace smashnotes_back.Controllers


{


    public static class RequestExtensions
    {
        public static async Task<string> ReadAsStringAsync(this Stream requestBody, bool leaveOpen = false)
        {
            using StreamReader reader = new(requestBody, leaveOpen: leaveOpen);
            var bodyAsString = await reader.ReadToEndAsync();
            return bodyAsString;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class Matchup4Controller : ControllerBase
    {
        [HttpPost]
        //lo siguiente funciona en dejar ok 200
        //public async Task<ActionResult> Post()
        //{


        //    return Ok();
        //}


        //lo siguiente funciona en dejar ok 200 y reenvia data
        //[HttpPost]
        //public string  Post()
        //{
        //    //var requestBody = await Request.Body.ReadAsStringAsync();
        //    return "aaa";
        //}


        [HttpPost]
        public async Task<ActionResult> Post()
        {

      
            return Ok();
        }


        //public async Task<ActionResult> Post([FromBody] string value)
        //{



        //    return Ok();
        //}
    }
}

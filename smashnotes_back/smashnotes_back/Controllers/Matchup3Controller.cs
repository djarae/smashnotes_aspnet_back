using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace smashnotes_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Matchup3Controller : ControllerBase
    {
        // GET: api/<Matchup3Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Console.WriteLine("get 3");
            return new string[] { "value1", "value2xxdxdxdxdsxd" };
        }

        // GET api/<Matchup3Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Console.WriteLine("get 3");
            return "value";
        }

        // POST api/<Matchup3Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Console.WriteLine("aaASDASDASDASDa");
            //return new string[] { "valueZ", "valuezx" };
        }


        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] string value)
        //{
        //    //if (student == null)
        //    //{
        //    //    return BadRequest("Not found");
        //    //}

        //    //_studentContext.Students.Add(student);
        //    //await _studentContext.SaveChangesAsync();
        //    //await Console.WriteLine("aaASDASDASDASDa");
        //    return Ok();
        //}

        // PUT api/<Matchup3Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Matchup3Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

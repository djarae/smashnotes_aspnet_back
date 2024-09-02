using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using System.Xml;
using Newtonsoft.Json;

namespace smashnotes_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Matchup2Controller : ControllerBase
    {
        internal class Product
        {
            public String[] Sizes { get; set; }
            public decimal Price { get; set; }
            public DateTime Expiry { get; set; }
            public string Name { get; set; }
        };


        //[HttpGet(Name = "GetMatchup2")]
        //public string Get2()
        //{
        //    System.Diagnostics.Debug.WriteLine("pruebiña matvchups22");
        //    Product product = new Product
        //    {
        //        Name = "Apple",
        //        Expiry = new DateTime(2008, 12, 28),
        //        Price = 3.99M,
        //        Sizes = new[] { "Small", "Medium", "Large" }
        //    };

        //    string json = JsonConvert.SerializeObject(product, Newtonsoft.Json.Formatting.Indented);
        //    Console.WriteLine(json);



        //    return json;
        //}

        // POST api/<ValuesController>  
      
        
        [HttpPost(Name = "PostMatchup2")]
        public string Post2()
        {
            Console.WriteLine("aaASDASDASDASDa");
            return "aad";
        }



    }
}

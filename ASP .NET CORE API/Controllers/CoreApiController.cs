using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiCorePizza.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CoreApiController : ControllerBase
    {
        // GET: api/<CoreApiController>
        [HttpGet]
        public IEnumerable<String> Get()
        {
            return new String[] { "https://s3.amazonaws.com/codecademy-content/programs/react/ravenous/pizza.jpg",
            "1010 Paddington Way", "Flavortown", "NY",
            "10101", "Italian", "5", "90" };
        }

        // POST api/<CoreApiController>

        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */
    }
}

/* GET api/<CoreApiController>/5
[HttpGet("{id}")]
public string Get(int id)
{
    return "value";
}
*/

/*
// PUT api/<CoreApiController>/5
[HttpPut("{id}")]
public void Put(int id, [FromBody] string value)
{
}

// DELETE api/<CoreApiController>/5
[HttpDelete("{id}")]
public void Delete(int id)
{
}
*/
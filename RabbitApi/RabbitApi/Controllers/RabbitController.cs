using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitApi.Models;

namespace RabbitApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        // GET: api/Rabbit
        [HttpGet]
        public IEnumerable<Rabbit> Get()
        {
            Rabbit r1 = new Rabbit(Rabbit.FurColors.Grey, Rabbit.EyeColors.Black, Rabbit.Gender.Female);
            Rabbit r2 = new Rabbit(Rabbit.FurColors.Black, Rabbit.EyeColors.Blue, Rabbit.Gender.Male);
            Rabbit r3 = new Rabbit(Rabbit.FurColors.Brown, Rabbit.EyeColors.Red, Rabbit.Gender.Male);
            
            List<Rabbit> rabbit = new List<Rabbit>();
            rabbit.Add(r1);
            rabbit.Add(r2);
            rabbit.Add(r3);
            return rabbit;
        }

        // GET: api/Rabbit/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Rabbit
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Rabbit/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

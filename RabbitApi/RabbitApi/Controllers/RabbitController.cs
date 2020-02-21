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

        private static List<Rabbit> rabbits = new List<Rabbit>();
        public RabbitController()
        {
            Rabbit r1 = new Rabbit() { Age = 4, EyeColor = EyeColors.Black, FurColor = FurColors.Black, Genders = Genders.Female};
            Rabbit r2 = new Rabbit() { Age = 3, EyeColor = EyeColors.Blue, FurColor = FurColors.Brown, Genders = Genders.Male };
            Rabbit r3 = new Rabbit() { Age = 2, EyeColor = EyeColors.Red, FurColor = FurColors.White, Genders = Genders.Female};

            if (!rabbits.Any())
            {
                rabbits.Add(r1);
                rabbits.Add(r2);
                rabbits.Add(r3);
            }
        } 
        // GET: api/Rabbit
        [HttpGet]
        public IEnumerable<Rabbit> Get()
        {
            return rabbits;
        }

        // GET: api/Rabbit/5
        [HttpGet("{id}", Name = "Get")]
        public Rabbit Get(int id)
        {
           return rabbits[id - 1];
        }

        // POST: api/Rabbit
        [HttpPost]
        public IActionResult Post([FromBody] Rabbit model)
        {
            if (ModelState.IsValid)
            {
                rabbits.Add(model);
                return Ok();
            }
            return BadRequest();
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

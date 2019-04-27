using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend
{
    [Route("api/[controller]")]
    [ApiController]
    public class SneakerController : ControllerBase
    {
        Sneakers[] sneaks = new Sneakers[]
        {
            new Sneakers {Id = 1, Name = "Yeezy Boost 350 V2 'Clay'", Brand="Adidas", Gender="Men", Description = "Shoes", Price = 265},
            new Sneakers {Id = 2, Name = "NMD_R1 'Duck Camo'", Brand="Adidas", Gender="Men", Description = "Shoes", Price = 85},
            new Sneakers {Id = 3 , Name = "SF Air Force 1 High 'Winter Camo'", Brand="Nike", Gender="Men", Description = "Shoes", Price = 115},
        };
        [HttpGet]
        public IEnumerable<Sneakers> Get()
        {
            return sneaks;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var sneak = sneaks.FirstOrDefault((s) => s.Id == id);

            if(sneak == null)
            {
                return NotFound();
            }
            return Ok(sneak);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
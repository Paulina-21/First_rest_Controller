using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_rest_Controller.Managers;
using First_rest_Controller.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace First_rest_Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemManager _manager = new ItemManager();

        // GET: api/<ItemController>

        //?name=br&quality=6&quantity=4
        [HttpGet()]
        public IEnumerable<Item> Get([FromQuery]string name,[FromQuery] string quality,[FromQuery] string quantity)
        {
            return _manager.GetAll(name,quality,quantity);
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<ItemController>
        [HttpPost]
        public Item Post([FromBody] Item value)
        {
            return _manager.Add(value); 
        }

        // PUT api/<ItemController>/5
        [HttpPut("{id}")]
        public Item Put(int id, [FromBody] Item value)
        {
            return _manager.Update(value.Id, value);
        }

        // DELETE api/<ItemController>/5
        [HttpDelete("{id}")]
        public Item Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}

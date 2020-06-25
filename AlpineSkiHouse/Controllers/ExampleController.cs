﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlpineSkiHouse.Controllers
{
    
    [Route("api")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private object locker = new object();
        // GET: api/<ExampleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            lock (locker) 
            {
                Console.WriteLine("");

            }
            return new string[] { "value1", "value2" };
        }

        // GET api/<ExampleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExampleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

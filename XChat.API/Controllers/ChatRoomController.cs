using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace XChat.API.Controllers
{
    [Route("api/[controller]")]
    public class ChatRoomController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;

        public ChatRoomController(IWebHostEnvironment environment)
        {
            _hostingEnvironment = environment;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var path = Path.Combine(_hostingEnvironment.ContentRootPath, "App_Data\\chat-rooms.json");
                string allText = System.IO.File.ReadAllText(path);
                return Json(JsonSerializer.Deserialize<object>(allText));
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

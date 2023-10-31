using Microsoft.AspNetCore.Mvc;
using MusicLibraryAPI.Models;
;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicLibraryAPI.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Songs
        [HttpGet]
        public IActionResult Get()
        {
            var songs = _context.Songs.ToList();
            return StatusCode(200, songs);
        }

        // GET api/Songs/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Songs
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Songs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Songs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

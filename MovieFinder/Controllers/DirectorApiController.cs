using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorApiController : ControllerBase
    {
        // GET: api/<DirectorApiController>

        private readonly MovieContext _context = new MovieContext();
        // GET: api/<DirectorController>
        [HttpGet]
        public async Task<ActionResult<List<Director>>> Get()
        {
            var d = await _context.Directors.ToListAsync();
            if (d is null)
            {
                return NoContent();
            }
            return d;
        }

        // GET api/<DirectorApiController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Movie>>>Get(int id)
        {
            var movies = await _context.Movies
              .Where(m => m.Director.Id == id).ToListAsync();
            return movies;
        }

        // POST api/<DirectorApiController>
        [HttpPost]
        public IActionResult Post([FromBody] Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChangesAsync();
            return Ok();
        }

        // PUT api/<DirectorApiController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Director d)
        {
            var director = _context.Directors.FirstOrDefault(m => m.Id == id);
            if (director is null)
            {
                return NotFound();
            }
            director.Name = d.Name;
            director.SurName = d.SurName;
            _context.Directors.Update(director);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<DirectorApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var director = _context.Directors.FirstOrDefault(m => m.Id == id);
            if (director is null)
            {
                return NotFound();
            }
            _context.Directors.Remove(director);
            _context.SaveChanges();
            return Ok();
        }
    }
}

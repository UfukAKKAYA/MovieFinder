using Microsoft.AspNetCore.Mvc;
using MovieFinder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieApiController : ControllerBase
    {
        private readonly MovieContext _context = new MovieContext();

        // GET: api/<MovieApiController>
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> Get()
        {
            var y = await _context.Movies.ToListAsync();
            if (y is null)
            {
                return NoContent();
            }
            return y;
        }

        // GET api/<MovieApiController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieRecord>> Get(int id)
        {

            var movie = await _context.Movies
                .Include(m => m.Director).FirstOrDefaultAsync(m => m.Id == id);

            var catogory = await _context.MovieCategories.Include(c => c.Category).Where(m => m.MovieId == id).ToListAsync();

            if (movie == null)
            {
                return NoContent();
            }

            MovieRecord movieRecord = new MovieRecord();
            movieRecord.Categories = new List<Category>();
            movieRecord.Movie = movie;


            foreach (MovieCategory c in catogory)
            {
                movieRecord.Categories.Add(c.Category);
            }
            return movieRecord;
        }

        // POST api/<MovieApiController>
        [HttpPost]
        public IActionResult Post([FromBody] Movie m)
        {
            _context.Movies.Add(m);
            _context.SaveChangesAsync();
            return Ok();
        }

        // PUT api/<MovieApiController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Movie m)
        {
            if (id != m.Id)
            {
                return NotFound();
            }

            var movie = _context.Movies
            .Include(m => m.Director).FirstOrDefault(m => m.Id == id);
            if (movie is null)
            {
                return NotFound();
            }

            movie.NameTr = m.NameTr;
            movie.NameEN = m.NameEN;
            movie.LogoUrl = m.LogoUrl;
            movie.TrailerUrl = m.TrailerUrl;
            movie.Score = m.Score;
            movie.ProductionYear = m.ProductionYear;

            _context.Movies.Update(m);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<MovieApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie is null)
            {
                return NotFound();
            }
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return Ok();
        }
    }
}

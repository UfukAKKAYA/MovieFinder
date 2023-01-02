using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using MovieFinder.Models;
using Newtonsoft.Json;

namespace MovieFinder.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context = new MovieContext();
        private readonly IStringLocalizer<MoviesController> _localizer;
        /*
        public MoviesController(MovieContext context)
        {
            _context = context;
        }
        */
        // GET: Movies


        public MoviesController(IStringLocalizer<MoviesController> localizer)
        {
            _localizer = localizer;
        }


        public async Task<IActionResult> Index()
        {
            List<Movie> movies = new List<Movie>();
            var hhtc = new HttpClient();
            var response = await hhtc.GetAsync("https://localhost:44358/api/MovieApi");
            string resString = await response.Content.ReadAsStringAsync();
            movies = JsonConvert.DeserializeObject<List<Movie>>(resString);
            return View(movies);
        }

        // GET: Movies
        public async Task<IActionResult> MovieDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*
            MovieRecord movieRecord = new MovieRecord();
            var hhtc = new HttpClient();
            string getStr = "https://localhost:44358/api/MovieApi/" + id.ToString();
            var response = await hhtc.GetAsync(getStr);
            string resString = await response.Content.ReadAsStringAsync();
            movieRecord = JsonConvert.DeserializeObject<MovieRecord>(resString);
            */
            



            var movie = await _context.Movies
                .Include(m => m.Director).FirstOrDefaultAsync(m => m.Id == id);

            var catogory = await _context.MovieCategories.Include(c => c.Category).Where(m => m.MovieId == id).ToListAsync();

            if (movie == null)
            {
                return NotFound();
            }

            MovieRecord movieRecord = new MovieRecord();
            movieRecord.Categories = new List<Category>();
            movieRecord.Movie = movie;
            
            
            foreach(MovieCategory c in catogory)
            {
                movieRecord.Categories.Add(c.Category);
            }
            
            return View(movieRecord);
        }

        public async Task<IActionResult> DirectorMovies(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<Movie> movies = new List<Movie>();
            var hhtc = new HttpClient();
            string getStr = "https://localhost:44358/api/DirectorApi/" + id.ToString();
            var response = await hhtc.GetAsync(getStr);
            string resString = await response.Content.ReadAsStringAsync();
            movies = JsonConvert.DeserializeObject<List<Movie>>(resString);

            var director = await _context.Directors.Where(d => d.Id == id).ToListAsync();

            if (director == null)
            {
                return NotFound();
            }

            TempData["director"] = director[0].Name + director[0].SurName;

            return View(movies);
            /*


            var movies = await _context.Movies
                .Where(m => m.Director.Id == id).ToListAsync();

            if (movies == null)
            {
                return NotFound();
            }

            var director = await _context.Directors.Where(d => d.Id == id).ToListAsync();
           
            if (director == null)
            {
                return NotFound();
            }

            TempData["director"] = director[0].Name + director[0].SurName;

            return View(movies);
            */
        } 
        
        public async Task<IActionResult> MovieCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catagoryMovies = await _context.MovieCategories.Include(m => m.Movie)
                .Where(m => m.CategoryId == id).ToListAsync();

            if (catagoryMovies == null)
            {
                return NotFound();
            }

            List<Movie> movies = new List<Movie>();

            foreach(MovieCategory cm in catagoryMovies)
            {
                movies.Add(cm.Movie);
            }

            var categorys = await _context.Categories.Where(d => d.Id == id).ToListAsync();

            TempData["category"] = categorys[0].Type.ToString();

            return View(movies);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameTr,NameEN,LogoUrl,TrailerUrl,ProductionYear,Score,DescriptionTR,DescriptionEN")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameTr,NameEN,LogoUrl,TrailerUrl,ProductionYear,Score,DescriptionTR,DescriptionEN")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}

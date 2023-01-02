using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieFinder.Models;
using Newtonsoft.Json;

namespace MovieFinder.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DirectorsController : Controller
    {
        private readonly MovieContext _context = new MovieContext();

        /*
        public DirectorsController(MovieContext context)
        {
            _context = context;
        }
        */

        // GET: Directors
        public async Task<IActionResult> Index()
        {
            List<Director> directors = new List<Director>();
            var hhtc = new HttpClient();
            string getStr = "https://localhost:44358/api/DirectorApi";
            var response = await hhtc.GetAsync(getStr);
            string resString = await response.Content.ReadAsStringAsync();
            directors = JsonConvert.DeserializeObject<List<Director>>(resString);
            return View(directors);
        }

        // GET: Directors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var director = await _context.Directors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (director == null)
            {
                return NotFound();
            }

            return View(director);
        }

        // GET: Directors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Directors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SurName")] Director director)
        {
            if (ModelState.IsValid)
            {
                List<Director> directors = new List<Director>();
                var hhtc = new HttpClient();
                string getStr = "https://localhost:44358/api/DirectorApi";
                string directorStr = JsonConvert.SerializeObject(director);
                var buffer = System.Text.Encoding.UTF8.GetBytes(directorStr);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = hhtc.PostAsync(getStr, byteContent).Result;

                /*

                      _context.Add(director);
                      await _context.SaveChangesAsync();
                      RedirectToAction(nameof(Index));
                     */

                return RedirectToAction(nameof(Index));
            }
            return View(director);
        

        }

        // GET: Directors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var director = await _context.Directors.FindAsync(id);
            if (director == null)
            {
                return NotFound();
            }
            return View(director);
        }

        // POST: Directors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SurName")] Director director)
        {
            if (id != director.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {                    
                    var hhtc = new HttpClient();
                    string getStr = "https://localhost:44358/api/DirectorApi/" + id.ToString();
                    string directorStr = JsonConvert.SerializeObject(director);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(directorStr);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var result = hhtc.PutAsync(getStr, byteContent).Result;
                    /*
                    _context.Update(director);
                    await _context.SaveChangesAsync();
                    */
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DirectorExists(director.Id))
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
            return View(director);
        }

        // GET: Directors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var director = await _context.Directors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (director == null)
            {
                return NotFound();
            }

            return View(director);
        }

        // POST: Directors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            /*  
            var director = await _context.Directors.FindAsync(id);
            _context.Directors.Remove(director);
            await _context.SaveChangesAsync();
            */

            var hhtc = new HttpClient();
            string getStr = "https://localhost:44358/api/DirectorApi/" + id.ToString();            
            var result = hhtc.DeleteAsync(getStr).Result;
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AddMovieIndex(int id)
        {
            List<Movie> movies = new List<Movie>();
            var hhtc = new HttpClient();
            var response = await hhtc.GetAsync("https://localhost:44358/api/MovieApi");
            string resString = await response.Content.ReadAsStringAsync();
            movies = JsonConvert.DeserializeObject<List<Movie>>(resString);
            TempData["director"] = id;
            return View(movies);
        }

        public async Task<IActionResult> AddMovie(int id, int dirId)
        {
            var movie = await _context.Movies.FindAsync(id);
            var director = await _context.Directors.FindAsync(dirId);
            movie.Director = director;
            _context.Update(movie);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool DirectorExists(int id)
        {
            return _context.Directors.Any(e => e.Id == id);
        }
    }
}

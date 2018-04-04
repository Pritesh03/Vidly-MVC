using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        ApplicationDbContext _context;

        //Initialize a DbContext
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //Dispose all the disposable objects in this overriden function
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }

        // GET: Get the list of all the movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        } 
        
        //Sho details of each movie
        public ActionResult Details(int? Id)
        {
            var movie = _context.Movies.Include(m => m.Genre).FirstOrDefault(m => m.Id == Id);
            return View(movie);
        }

        //Create a new Movie and save it to database
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel() {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        //Save the movie to Database
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if(movie.Id == 0)
            {
                _context.Movies.Add(movie);
               
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.GenreId = movie.GenreId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //Edit a Movie
        public ActionResult Edit(int? Id)
        {
            var movie = _context.Movies.Single(m => m.Id == Id);

            var viewModel = new MovieFormViewModel() {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

           return View("MovieForm", viewModel);
        }
    }
}
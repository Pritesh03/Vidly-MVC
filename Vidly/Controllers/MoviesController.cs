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
        ApplicationDbContext context;

        public MoviesController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        } 
        
        public ActionResult Details(int? Id)
        {
            var movie = context.Movies.Include(m => m.Genre).FirstOrDefault(m => m.Id == Id);
            return View(movie);
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> lstMovies = new List<Movie>() {
            new Movie(){ Id = 1, Name = "The Jungle Book" },
            new Movie(){ Id = 2, Name = "Dad's Army" },
            new Movie(){ Id = 3, Name = "The Green Mile" }
        };
        // GET: Movies
        public ActionResult Index()
        {
            return View(lstMovies);
        }        
        
    }
}
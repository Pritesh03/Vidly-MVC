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
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() {Id = 10001, Name = "The Jungle Book" };
            List<Customer> lstCustomer = new List<Customer>() {
                new Customer(){ Id = 50001, Name = "Sheldon Cooper"},
                new Customer(){ Id = 50002, Name = "Kaylee Cucoo"}
            };

            MovieCustomersViewModel movieCustomers = new MovieCustomersViewModel() {
                Movie = movie,
                Customers = lstCustomer
            };


            return View(movieCustomers);
        }        
        
    }
}
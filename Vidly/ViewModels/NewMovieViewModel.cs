using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewMovieViewModel
    {
        //Movie
        public Movie Movie { get; set; }

        //Genres
        public IEnumerable<Genre> Genres { get; set; }
    }
}
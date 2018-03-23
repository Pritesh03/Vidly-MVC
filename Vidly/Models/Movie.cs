using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        //Movie's Id
        public int Id { get; set; }

        //Movie's Name
        public string Name { get; set; }

        //Release Date of the movie
        public DateTime ReleaseDate { get; set; }

        //Date on which this movie was added to the Vidly collection
        public DateTime DateAdded { get; set; }

        //Number in Vidly stock
        public byte NumberInStock { get; set; }

        //Genre of the Movie
        public Genre Genre { get; set; }

        //Genre Id of the Movie for EF
        public byte GenreId { get; set; }
    }
}
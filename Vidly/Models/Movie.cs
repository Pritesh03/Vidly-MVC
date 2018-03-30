using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        //Movie's Id
        public int Id { get; set; }

        //Movie's Name
        [Required]
        public string Name { get; set; }

        //Release Date of the movie
        [Required]
        [Display(Name= "Release Date")]
        public DateTime ReleaseDate { get; set; }

        //Date on which this movie was added to the Vidly collection
        [Required]
        [Display(Name = "Date added to our store")]
        public DateTime DateAdded { get; set; }

        //Number in Vidly stock
        [Required]
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

        //Genre of the Movie
        public Genre Genre { get; set; }

        //Genre Id of the Movie for EF
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
    }
}
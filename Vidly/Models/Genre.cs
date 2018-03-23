using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genre
    {
        //Id of the Genre
        public byte Id { get; set; }

        //Genre Name
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}
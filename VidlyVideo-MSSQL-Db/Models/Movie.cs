using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie name")]
        public string Name { get; set; }

        public string PosterURL { get; set; }

        [Required(ErrorMessage = "Please enter movie genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Please enter movie release date mm/dd/yyyy")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }

        [Required(ErrorMessage = "Please enter number of movies in stock")]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }

    }


}
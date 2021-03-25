using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class ExistingMovieViewModel
    {
        
        public Movie Movie;
        public IEnumerable<Movie> Movies { get; set; }

    }

}
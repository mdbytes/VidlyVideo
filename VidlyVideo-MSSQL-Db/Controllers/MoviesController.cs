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
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            List<Movie> movies = _context.Movies.ToList();

            List<Movie> SortedMovies = movies.OrderByDescending(m => m.ReleaseDate).ToList();

            var UserEmail = "";

            UserEmail = User.Identity.Name;
            
            var ViewModel = new MovieListViewModel
            {
                Movies = SortedMovies,
                UserEmail = UserEmail
            };

            return View(ViewModel);
        }


        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.AddedDate = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.Genre = movie.Genre;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.PosterURL = movie.PosterURL;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }


        public ActionResult New()
        {
            var MovieList = _context.Movies.ToList();
            var viewModel = new NewMovieViewModel
            {
                Movies = MovieList

            };

            return View(viewModel);
        }


        public ActionResult Edit(int id)
        {

            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            } else
            {
                var viewModel = new ExistingMovieViewModel
                {
                    Movie = movie,
                    Movies = _context.Movies.ToList()
                };

                return View("Edit", viewModel);
            }
                

            
        }

        public ActionResult Delete(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            _context.Movies.Remove(movieInDb);

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");

        }

    }
}
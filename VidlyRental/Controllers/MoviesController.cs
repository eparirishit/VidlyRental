using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRental.Models;
using VidlyRental.ViewModels;

namespace VidlyRental.Controllers
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
        // GET: Movie
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult New()
        {
            var genreList = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Genres = genreList
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);

            if (movie == null)
                HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Id=1, Name="Harry Potter and the Philosopher's Stone"},
                new Movie(){Id=2, Name="Harry Potter and the Chamber of Secrets"},
                new Movie(){Id=3, Name="Harry Potter and the Prisoner of Azkaban"},
                new Movie(){Id=4, Name="Harry Potter and the Goblet of Fire"},
                new Movie(){Id=5, Name="Harry Potter and the Order of the Phoenix"},
                new Movie(){Id=6, Name="Harry Potter and the Half-Blood Prince"},
                new Movie(){Id=7, Name="Harry Potter and the Deathly Hallows – Part 1"},
                new Movie(){Id=8, Name="Harry Potter and the Deathly Hallows – Part 2"}

            };
        }

    }
}
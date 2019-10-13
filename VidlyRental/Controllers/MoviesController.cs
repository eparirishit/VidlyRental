using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRental.Models;

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
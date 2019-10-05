using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRental.Models;

namespace VidlyRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
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
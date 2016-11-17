using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoStore.Client.Controllers
{
    public class GenresController : Controller
    {
        private VideoStoreContext _db = new VideoStoreContext();

        // GET: Genres
        public ActionResult Index()
        {
            var genres = _db.Genres;

            ViewBag.Genres = genres;

            return View();
        }

        // GET: /Genres/1
        public ActionResult View(int id)
        {
            var genre = _db.Genres.FirstOrDefault(g => g.GenreId == id);

            if (genre == null)
            {
                return HttpNotFound();
            }

            ViewBag.Genre = genre;
            ViewBag.Movies = genre.Movies;

            return View();
        }
    }
}
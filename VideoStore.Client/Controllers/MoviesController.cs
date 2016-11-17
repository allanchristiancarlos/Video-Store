using System.Linq;
using VideoStore.Common;
using System.Web.Mvc;

namespace VideoStore.Client.Controllers
{
    public class MoviesController : Controller
    {
        private VideoStoreContext _db = new VideoStoreContext();

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _db.Movies.Include("Genre");

            ViewBag.Movies = movies;

            return View();
        }

        // GET: Movies/View/1
        public ActionResult View(int id)
        {
            var movie = _db.Movies.FirstOrDefault(m => m.MovieId == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            ViewBag.Movie = movie;
            ViewBag.Actors = movie?.Actors;

            return View();
        }
    }
}
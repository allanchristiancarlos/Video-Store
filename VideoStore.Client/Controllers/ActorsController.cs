using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoStore.Client.Controllers
{
    public class ActorsController : Controller
    {
        private VideoStoreContext _db = new VideoStoreContext();

        [Route(Name = "MoviesIndex")]
        public ActionResult Index()
        {
            var actors = _db.Actors;

            ViewBag.Actors = actors;

            return View();
        }

        // GET: Actor
        public ActionResult View(int id)
        {
            var actor = _db.Actors.FirstOrDefault(a => a.ActorId == id);

            if (actor == null)
            {
                return HttpNotFound();
            }

            ViewBag.Actor = actor;
            ViewBag.Movies = actor.Movies;

            return View();
        }
    }
}
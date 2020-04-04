using GigHub.Models;
using GigHub.ViewModel;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext DB;
        public GigsController()
        {
            DB = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = DB.Genre.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            var gig = new Gig
            {
                Venue = viewModel.Venue,
                ArtistId = User.Identity.GetUserId(),
                GenreId = viewModel.Genre,
                DateTime = DateTime.Parse(string.Format("{0}{1}", viewModel.Date, viewModel.Time)),
            };

            DB.Gigs.Add(gig);
            DB.SaveChanges();

            return RedirectToAction("Index", "Home");


        }
    }
}
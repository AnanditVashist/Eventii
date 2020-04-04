using GigHub.Models;
using GigHub.ViewModel;
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

        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = DB.Genre.ToList()
            };
            return View(viewModel);
        }
    }
}
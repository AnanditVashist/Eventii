using GigHub.Models;
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

            return View();
        }
    }
}
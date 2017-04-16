using System.Linq;
using System.Web.Mvc;
using EFDemoProject.Infrastructure.Data.EF;

namespace EFDemoProject.Controllers
{
    public class HomeController : Controller
    {

        private BugTrackerContext db = new BugTrackerContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
    }
}
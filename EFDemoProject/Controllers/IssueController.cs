using System.Web.Mvc;
using EFDemoProject.ViewModels;

namespace EFDemoProject.Controllers
{
    public class IssueController : Controller
    {
        // GET: Issue
        public ActionResult Index()
        {
            return View();
        }

	    public ActionResult Get(int id)
	    {
		    return View();
	    }

	    public ActionResult Create()
	    {
		    return View();
	    }

		[HttpPost]
	    public ActionResult Create(IssueCreateModel model)
	    {
		    return View();
	    }
    }
}
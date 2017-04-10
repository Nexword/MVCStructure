using System.Linq;
using System.Web.Mvc;
using EFDemoProject.Models.EF;
using EFDemoProject.ViewModels;

namespace EFDemoProject.Controllers
{
    public class IssueController : Controller
    {
		private readonly BugTrackerContext context = new BugTrackerContext();
		
        // GET: Issue
        public ActionResult Index()
        {
	        var issues = context.Issues.AsEnumerable();
			var model = issues.Select(x => new IssueViewModel
	        {
				Id = x.Id,
				Title = x.Title,
				Status = x.Status.ToString(),
				Price = x.Price
	        });

            return View(model);
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
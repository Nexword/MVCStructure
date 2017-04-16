using System;
using System.Linq;
using System.Web.Mvc;
using EFDemoProject.Domain.Core.Entities;
using EFDemoProject.Domain.Core.Enums;
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
		    var issue = context.Issues.Find(id);
		    if (issue == null)
		    {
			    return HttpNotFound($"Issue with id = {id} not found");
		    }

		    var model = new IssueViewModel
		    {
			    Title = issue.Title,
			    Price = issue.Price,
			    Status = issue.Status.ToString()
		    };

		    return View("Details", model);
	    }

	    public ActionResult Create()
	    {
		    return View();
	    }

		[HttpPost]
	    public ActionResult Create(IssueCreateModel model)
		{
			var today = DateTime.Today;

			var newIssue = new Issue
			{
				Title = model.Title,
				Description = model.Description,
				BeginDate = today,
				EndDate = today.AddDays(5),
				Price = (decimal) model.Price,
				Status = IssueStatuses.New
			};

			context.Issues.Add(newIssue);
			context.SaveChanges();

			return RedirectToAction("Index");
		}
    }
}
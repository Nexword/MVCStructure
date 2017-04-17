using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFDemoProject.Domain.Core.Entities;
using EFDemoProject.Domain.Interfaces;
using EFDemoProject.Infrastructure.Data.EF;

namespace EFDemoProject.Infrastructure.Data
{
    public class IssueRepository : IIssueRepository
    {
        private BugTrackerContext db;

        public IssueRepository()
        {
            db = new BugTrackerContext();
        }

        public IEnumerable<Issue> GetIssueList()
        {
            return db.Issues.ToList();
        }

        public Issue GetIssue(int id)
        {
            return db.Issues.Find(id);
        }

        public void Create(Issue item)
        {
            db.Issues.Add(item);
        }

        public void Update(Issue item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Issue issue = db.Issues.Find(id);
            if (issue != null)
                db.Issues.Remove(issue);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IQueryable<Issue> Issues
        {
            get { return db.Issues; }
        }

        public IQueryable<User> Users
        {
            get { return db.Users; }
        }
    }
}

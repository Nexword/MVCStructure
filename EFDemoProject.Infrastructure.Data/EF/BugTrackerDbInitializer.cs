using System;
using System.Collections.Generic;
using System.Data.Entity;
using EFDemoProject.Domain.Core.Entities;
using EFDemoProject.Domain.Core.Enums;

namespace EFDemoProject.Infrastructure.Data.EF
{
    public class BugTrackerDbInitializer : DropCreateDatabaseIfModelChanges<BugTrackerContext>
    {
        protected override void Seed(BugTrackerContext context)
        {
            Issue issue1 = new Issue()
            {
                Title = "First Issue",
                BeginDate = DateTime.Now,
                Status = IssueStatuses.New,
                Description = "It is first issue"
            };
            Issue issue2 = new Issue()
            {
                Title = "Second Issue",
                BeginDate = DateTime.Now,
                Status = IssueStatuses.New,
                Description = "It is second issue"
            };
            Issue issue3 = new Issue()
            {
                Title = "Third Issue",
                BeginDate = DateTime.Now,
                Status = IssueStatuses.New,
                Description = "It is third issue"
            };

            context.Issues.Add(issue1);
            context.Issues.Add(issue2);
            context.Issues.Add(issue3);

            User user1 = new User()
            {
                Role = UserRoles.Administrator,
                CreateDate = DateTime.Now
            };
            User user2 = new User()
            {
                Role = UserRoles.Developer,
                CreateDate = DateTime.Now,
                Issues = new List<Issue>()
            };

            user2.Issues.Add(issue1);
            user2.Issues.Add(issue2);

            context.Users.Add(user1);
            context.Users.Add(user2);
            base.Seed(context);
        }
    }
}
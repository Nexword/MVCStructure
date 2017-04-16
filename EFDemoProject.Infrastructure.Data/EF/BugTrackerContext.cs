using System.Data.Entity;
using EFDemoProject.Domain.Core.Entities;

namespace EFDemoProject.Infrastructure.Data.EF
{
    public class BugTrackerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Issue> Issues { get; set; }
    }
}
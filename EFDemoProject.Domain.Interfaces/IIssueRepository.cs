using System.Collections.Generic;
using System.Linq;
using EFDemoProject.Domain.Core.Entities;

namespace EFDemoProject.Domain.Interfaces
{
    public interface IIssueRepository
    {
        IQueryable<Issue> Issues { get; }
        IQueryable<User> Users { get; }
        IEnumerable<Issue> GetIssueList();
        Issue GetIssue(int id);
        void Create(Issue item);
        void Update(Issue item);
        void Delete(int id);
        void Save();
    }
}

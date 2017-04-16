using System.Collections.Generic;
using EFDemoProject.Domain.Core.Entities;

namespace EFDemoProject.Domain.Interfaces
{
    public interface IIssueRepository
    {
        IEnumerable<Issue> GetIssueList();
        Issue GetIssue(int id);
        void Create(Issue item);
        void Update(Issue item);
        void Delete(int id);
        void Save();
    }
}

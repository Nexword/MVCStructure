using System.Collections.Generic;
using System.Linq;
using EFDemoProject.Domain.Core.Enums;
using EFDemoProject.Domain.Interfaces;

namespace EFDemoProject.Infrastructure.Business
{
    public class IssueHelper
    {
        private IIssueRepository repo;

        public IssueHelper(IIssueRepository repo)
        {
            this.repo = repo;
        }

        public int GetIssueCountInCurrentStatus(byte status)
        {
            return repo.Issues.Count(i => (byte)i.Status == status);
        }

        public decimal GetIssuePricedInCurrentStatuses(byte status)
        {
            return repo.Issues.Where(i => (byte) i.Status == status).Sum(p => p.Price);
        }

        public bool HaveOpenIssues
        {
            get
            {
                return repo.Issues.All(i => i.Status == IssueStatuses.Open);
            } 
        }

        public List<int> GetReOpenIssueIds()
        {
            return repo.Issues.Where(i => i.Status == IssueStatuses.ReOpened).Select(x => x.Id).ToList();
        }

    }
}

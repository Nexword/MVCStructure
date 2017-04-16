using System;
using EFDemoProject.Domain.Core.Enums;

namespace EFDemoProject.Domain.Core.Entities
{
    public class Issue
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime? BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        public IssueStatuses Status { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
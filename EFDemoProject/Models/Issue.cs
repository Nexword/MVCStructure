using System;
using EFDemoProject.Models.Enums;

namespace EFDemoProject.Models
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
    }
}
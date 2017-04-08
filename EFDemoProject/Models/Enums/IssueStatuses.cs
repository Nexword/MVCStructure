using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemoProject.Models.Enums
{
    public enum IssueStatuses : byte
    {
        New,
        Open,
        InProgress,
        CodeReview,
        ReOpened,
        Resolved,
        Closed
    }
}
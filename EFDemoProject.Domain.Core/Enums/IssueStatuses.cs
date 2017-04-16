namespace EFDemoProject.Domain.Core.Enums
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
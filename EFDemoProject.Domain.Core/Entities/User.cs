using EFDemoProject.Domain.Core.Enums;
using System;
using System.Collections.Generic;

namespace EFDemoProject.Domain.Core.Entities
{
    public class User
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public UserRoles Role { get; set; }

        public virtual List<Issue> Issues { get; set; }
    }
}
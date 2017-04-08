using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFDemoProject.Models.Enums;

namespace EFDemoProject.Models
{
    public class User
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public UserRoles Role { get; set; }

        public virtual List<Issue> Issues { get; set; }
    }
}
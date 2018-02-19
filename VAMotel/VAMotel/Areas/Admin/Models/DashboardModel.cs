using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VAMotel.Areas.Admin.Models
{
    public class DashboardModel
    {
        public int NumberOfAccounts { get; set; }
        public int NumberOfCategories { get; set; }
        public int NumberOfPosts { get; set; }
        public int NumberOfGroups { get; set; }
    }
}
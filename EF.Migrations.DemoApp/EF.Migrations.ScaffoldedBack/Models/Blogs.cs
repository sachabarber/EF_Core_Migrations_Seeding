using System;
using System.Collections.Generic;

namespace EF.Migrations.ScaffoldedBack.Models
{
    public partial class Blogs
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}

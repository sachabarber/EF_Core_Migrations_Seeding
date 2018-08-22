using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF.Migrations.DemoApp
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string CreatedDate { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderProject.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string BigImageUrl { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SmallImageUrl { get; set; }
    }
}
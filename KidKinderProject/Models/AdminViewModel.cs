using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinderProject.Models
{
    public class AdminViewModel
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
    }
}
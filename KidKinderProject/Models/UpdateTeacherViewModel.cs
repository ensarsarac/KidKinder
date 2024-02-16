using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinderProject.Models
{
    public class UpdateTeacherViewModel
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedinUrl { get; set; }
    }
}
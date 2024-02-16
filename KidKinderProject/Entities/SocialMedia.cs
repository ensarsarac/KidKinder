using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderProject.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaId { get; set; }
        public string Platform { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
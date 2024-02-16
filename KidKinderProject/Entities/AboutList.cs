using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderProject.Entities
{
    public class AboutList
    {
        [Key]
        public int AboutListId { get; set; }
        public string Description { get; set; }
    }
}
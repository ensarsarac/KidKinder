using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderProject.Entities
{
    public class Gallery
    {
        [Key]
        public int GalleryId { get; set; }
        public string Path { get; set; }
        public bool Status{ get; set; }
    }
}
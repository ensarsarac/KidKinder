using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderProject.Models
{
    public class CreateTeacherViewModel
    {
        [Required(ErrorMessage ="Ad alanı boş bırakılamaz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Öğretmen alanı boş bırakılamaz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Resim alanı boş bırakılamaz.")]
        public string ImageUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedinUrl { get; set; }
    }
}
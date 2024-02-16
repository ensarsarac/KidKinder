using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderProject.Entities
{
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AgeOfKids { get; set; }
        public byte TotalSeats { get; set; }
        public string ClassTime { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public List<BookASeat> BookASeats { get; set; }
    }
}
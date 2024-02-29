using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderProject.Entities
{
    public class BookASeat
    {
        [Key]
        public int BookASeatId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderProject.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime NotificationDate { get; set; }
    }
}
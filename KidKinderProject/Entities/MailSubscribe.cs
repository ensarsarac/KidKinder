using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinderProject.Entities
{
    public class MailSubscribe
    {
        [Key]
        public int MailSubscribeId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
    }
}
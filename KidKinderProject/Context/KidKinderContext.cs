﻿using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KidKinderProject.Context
{
    public class KidKinderContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<BookASeat> BookASeats { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<MailSubscribe> MailSubscribes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Notification> Notifications{ get; set; }
        public DbSet<Branch> Branches{ get; set; }
    }
}
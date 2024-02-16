﻿namespace KidKinderProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutLists",
                c => new
                    {
                        AboutListId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AboutListId);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        BigImageUrl = c.String(),
                        Header = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        SmallImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.BookASeats",
                c => new
                    {
                        BookASeatId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        ClassRoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookASeatId)
                .ForeignKey("dbo.Classrooms", t => t.ClassRoomId, cascadeDelete: true)
                .Index(t => t.ClassRoomId);
            
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ClassroomId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        AgeOfKids = c.String(),
                        TotalSeats = c.Byte(nullable: false),
                        ClassTime = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ClassroomId);
            
            CreateTable(
                "dbo.Communications",
                c => new
                    {
                        CommunicationId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CommunicationId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        SendDate = c.DateTime(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Header = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.FeatureId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.GalleryId);
            
            CreateTable(
                "dbo.MailSubscribes",
                c => new
                    {
                        MailSubscribeId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.MailSubscribeId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        IconUrl = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        Platform = c.String(),
                        Icon = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(),
                        ImageUrl = c.String(),
                        FacebookUrl = c.String(),
                        TwitterUrl = c.String(),
                        LinkedinUrl = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Title = c.String(),
                        Comment = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.TestimonialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookASeats", "ClassRoomId", "dbo.Classrooms");
            DropIndex("dbo.BookASeats", new[] { "ClassRoomId" });
            DropTable("dbo.Testimonials");
            DropTable("dbo.Teachers");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Services");
            DropTable("dbo.MailSubscribes");
            DropTable("dbo.Galleries");
            DropTable("dbo.Features");
            DropTable("dbo.Contacts");
            DropTable("dbo.Communications");
            DropTable("dbo.Classrooms");
            DropTable("dbo.BookASeats");
            DropTable("dbo.Abouts");
            DropTable("dbo.AboutLists");
        }
    }
}

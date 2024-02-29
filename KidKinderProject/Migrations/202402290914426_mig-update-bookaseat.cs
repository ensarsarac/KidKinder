namespace KidKinderProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migupdatebookaseat : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.BookASeats", new[] { "ClassRoomId" });
            CreateIndex("dbo.BookASeats", "ClassroomId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.BookASeats", new[] { "ClassroomId" });
            CreateIndex("dbo.BookASeats", "ClassRoomId");
        }
    }
}

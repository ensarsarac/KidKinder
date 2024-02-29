namespace KidKinderProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gallerytable_add_status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Galleries", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Galleries", "Status");
        }
    }
}

namespace UserManagementForGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class members1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.AspNetUsers", "Timestamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Timestamp");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}

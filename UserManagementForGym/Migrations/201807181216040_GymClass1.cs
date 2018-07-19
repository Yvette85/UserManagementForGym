namespace UserManagementForGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GymClass1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GymClasses", "Name", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.GymClasses", "Description", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GymClasses", "Description", c => c.String());
            AlterColumn("dbo.GymClasses", "Name", c => c.String());
        }
    }
}

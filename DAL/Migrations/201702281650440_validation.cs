namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.purple_Restaurant", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.purple_Restaurant", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.purple_Restaurant", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.purple_Restaurant", "City", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.purple_Restaurant", "PostCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.purple_Restaurant", "PostCode", c => c.String());
            AlterColumn("dbo.purple_Restaurant", "City", c => c.String(maxLength: 100));
            AlterColumn("dbo.purple_Restaurant", "Description", c => c.String());
            AlterColumn("dbo.purple_Restaurant", "Address", c => c.String());
            AlterColumn("dbo.purple_Restaurant", "Name", c => c.String());
        }
    }
}

namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameChange_TablePrefix1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.purple_Restaurant", "City", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.purple_Restaurant", "City", c => c.String());
        }
    }
}

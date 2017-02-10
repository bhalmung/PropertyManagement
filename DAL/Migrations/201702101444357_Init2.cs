namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RestaurentComments", "Restaurent_Id", c => c.Int());
            CreateIndex("dbo.RestaurentComments", "Restaurent_Id");
            AddForeignKey("dbo.RestaurentComments", "Restaurent_Id", "dbo.Restaurents", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RestaurentComments", "Restaurent_Id", "dbo.Restaurents");
            DropIndex("dbo.RestaurentComments", new[] { "Restaurent_Id" });
            DropColumn("dbo.RestaurentComments", "Restaurent_Id");
        }
    }
}

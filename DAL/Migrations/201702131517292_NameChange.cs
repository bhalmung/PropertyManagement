namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameChange : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.RestaurentComments", newName: "RestaurantComments");
            RenameTable(name: "dbo.RestaurentRatings", newName: "RestaurantRatings");
            RenameTable(name: "dbo.Restaurents", newName: "Restaurants");
            RenameColumn(table: "dbo.RestaurantComments", name: "Restaurent_Id", newName: "Restaurant_Id");
            RenameIndex(table: "dbo.RestaurantComments", name: "IX_Restaurent_Id", newName: "IX_Restaurant_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.RestaurantComments", name: "IX_Restaurant_Id", newName: "IX_Restaurent_Id");
            RenameColumn(table: "dbo.RestaurantComments", name: "Restaurant_Id", newName: "Restaurent_Id");
            RenameTable(name: "dbo.Restaurants", newName: "Restaurents");
            RenameTable(name: "dbo.RestaurantRatings", newName: "RestaurentRatings");
            RenameTable(name: "dbo.RestaurantComments", newName: "RestaurentComments");
        }
    }
}

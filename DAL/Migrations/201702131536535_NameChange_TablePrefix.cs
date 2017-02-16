namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameChange_TablePrefix : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.RestaurantComments", newName: "purple_RestaurantComments");
            RenameTable(name: "dbo.RestaurantRatings", newName: "purple_RestaurantRating");
            RenameTable(name: "dbo.Restaurants", newName: "purple_Restaurant");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.purple_Restaurant", newName: "Restaurants");
            RenameTable(name: "dbo.purple_RestaurantRating", newName: "RestaurantRatings");
            RenameTable(name: "dbo.purple_RestaurantComments", newName: "RestaurantComments");
        }
    }
}

namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestaurentComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Comment = c.String(),
                        CommentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RestaurentRatings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Rating = c.Int(nullable: false),
                        RetingDate = c.DateTime(nullable: false),
                        RestaurentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurents", t => t.RestaurentId, cascadeDelete: true)
                .Index(t => t.RestaurentId);
            
            CreateTable(
                "dbo.Restaurents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Description = c.String(),
                        City = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RestaurentRatings", "RestaurentId", "dbo.Restaurents");
            DropIndex("dbo.RestaurentRatings", new[] { "RestaurentId" });
            DropTable("dbo.Restaurents");
            DropTable("dbo.RestaurentRatings");
            DropTable("dbo.RestaurentComments");
        }
    }
}

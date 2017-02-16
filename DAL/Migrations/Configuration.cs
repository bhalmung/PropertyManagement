namespace DAL.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.RestaurantdbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.RestaurantdbContext context)
        {
            //context.Restaurant.AddOrUpdate(new Restaurant()
            //{
            //    Name = "A",
            //    Address = "AddressA",
            //    City = "CityA",
            //    Description = "Desc",
            //    PostCode = "PCA",
            //    Ratings = new List<RestaurantRating>() { new RestaurantRating() { Rating = 5, RetingDate = DateTime.Now, UserName = "UserA" } }
            //});

            //context.SaveChanges();
        }
    }
}

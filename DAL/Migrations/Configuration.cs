namespace DAL.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.RestaurentdbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.RestaurentdbContext context)
        {
            context.Restaurent.AddOrUpdate(new Restaurent()
            {
                Name = "A",
                Address = "AddressA",
                City = "CityA",
                Description = "Desc",
                PostCode = "PCA",
                Ratings = new List<RestaurentRating>() { new RestaurentRating() { Rating = 5, RetingDate = DateTime.Now, UserName = "UserA" } }
            });

            context.SaveChanges();
        }
    }
}

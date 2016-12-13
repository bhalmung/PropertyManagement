using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PropertyManagement.DB
{
    public class PropertyManagementContext : DbContext
    {
        public PropertyManagementContext():base("DnCore")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        //Will need to have On model Creating Function here (To use Fluent API for db Mighrations)
        //I will learn aboout it later
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Configurations.Add(new CourseConfiguration());
        //}

        public DbSet<FeedLog> FeedLog { get; set; }
        public DbSet<Feed> Feed { get; set; }
        public DbSet<Image> FeedImages { get; set; }
        public DbSet<Feature> FeedFeature { get; set; }
        public DbSet<Property> FeedProperty { get; set; }
    }
}
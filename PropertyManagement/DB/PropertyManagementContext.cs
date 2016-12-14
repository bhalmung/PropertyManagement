using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PropertyManagement.DB
{

    //http://portals.baysoft-net.co.uk/XML_FEED/?b=4yHRIAqJ9628J1TeGdVGq4I40E25t8aj03YE5BNxmckCwkH5PfkV0kTBUYj353wO573EOJUQ5HW83buzU54VbbNAh8uvcO25HhL2K9X2KfQGX7q2d7Z1mh5ruo4m01a6nc9Aj5BUHrIw40T484544L8y21ceTmZS22V7x6BWWU56PcFtk50zDsX0ng21fSujeVP0Ht1j
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
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
        public PropertyManagementContext():base("PropertyManagement")
        {

        }

    

        public DbSet<FeedLog> FeedLog { get; set; }
        public DbSet<Feed> Feed { get; set; }
    }
}

using DomainModels;
 
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RestaurantdbContext: DbContext

    {
    
        public  RestaurantdbContext():base("name=DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //To add prefix to all tables names
            modelBuilder.Types().Configure(x => x.ToTable("purple_" + x.ClrType.Name));

            modelBuilder.Entity<Restaurant>().Property(x=>x.City).HasMaxLength(100);
        }

        public virtual  DbSet<Restaurant> Restaurant { get; set; }

        public virtual DbSet<RestaurantRating> Rating { get; set; }

        public virtual DbSet<RestaurantComments>  Comments { get; set; }
    }
}

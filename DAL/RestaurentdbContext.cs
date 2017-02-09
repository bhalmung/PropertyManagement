
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RestaurentdbContext: DbContext

    {
    
        public  RestaurentdbContext():base("name=DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual  DbSet<Restaurent> Restaurent { get; set; }

        public virtual DbSet<RestaurentRating> Rating { get; set; }

        public virtual DbSet<RestaurentComments>  Comments { get; set; }
    }
}

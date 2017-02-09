using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class RestaurantRepo
    {
        RestaurentdbContext _Context;
         public RestaurantRepo(RestaurentdbContext Context)
        {
            _Context = Context;
        }

        public IEnumerable<Restaurent> GetAllRestaurents()
        {
            return _Context.Restaurent.Include("RestaurentComments").Include("RestaurentRatings").AsNoTracking();
        }
    }
}

using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DAL
{
   public class RestaurantRepo
    {
        RestaurantdbContext _Context;
         public RestaurantRepo(RestaurantdbContext Context)
        {
            _Context = Context;
        }

        public IEnumerable<Restaurant> GetAllRestaurents()
        {
            return _Context.Restaurant.Include(X => X.Ratings).Include(x => x.Comments).AsNoTracking();
        }
    }
}

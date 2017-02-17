 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DomainModels;

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

        public void Delete(Restaurant r)
        {
            _Context.Restaurant.Remove(r);

            _Context.SaveChanges();
        }

        public Restaurant GetByRestaurantId(int restaurantId)
        {
            return _Context.Restaurant.Include(X => X.Ratings).Include(x => x.Comments).FirstOrDefault(x => x.Id == restaurantId);
        }

        public void Add(Restaurant r)
        {
            _Context.Restaurant.Add(r);

            _Context.SaveChanges();
        }

        public void Update(Restaurant r)
        {
            _Context.Entry(r).State = EntityState.Modified;

            _Context.SaveChanges();
        }
    }
}

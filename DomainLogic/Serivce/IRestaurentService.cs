using DomainModels;
 
using System.Collections.Generic;

namespace DomainLogic.Serivce
{
    public interface IRestaurentService
    {
        IEnumerable<Restaurant> GetAllRestaurent();
        void UpAdd(Restaurant r);
        Restaurant GetByRestaurantId(int RestaurantId);
        void Delete(int restaurantID);
    }
}
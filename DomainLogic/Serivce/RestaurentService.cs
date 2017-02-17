using DAL;
 
using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Serivce
{
  public  class RestaurentService : IRestaurentService
    {
        private RestaurantRepo _RestaurantRepo;
        public RestaurentService(RestaurantRepo RestaurantRepo ) {
            _RestaurantRepo = RestaurantRepo;
        }
        public IEnumerable<Restaurant> GetAllRestaurent()
        {
            return _RestaurantRepo.GetAllRestaurents();
        }

        public Restaurant GetByRestaurantId(int RestaurantId)
        {
           return _RestaurantRepo.GetByRestaurantId(RestaurantId);
        }

        public void UpAdd(Restaurant r)
        {
            if (r.Id>0)
            {
                _RestaurantRepo.Update(r);
            }else
            {
                _RestaurantRepo.Add(r);
            }
        }
    }
}

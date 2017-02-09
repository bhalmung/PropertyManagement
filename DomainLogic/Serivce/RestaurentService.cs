using DAL;
using Models;
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
        public IEnumerable<Restaurent> GetAllRestaurent()
        {
            return _RestaurantRepo.GetAllRestaurents();
        }
    }
}

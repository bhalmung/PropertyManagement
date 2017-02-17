using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
   
   public class Restaurant
    {
          
        public int Id { get; set; }
        public String Name { get; set; }
    
        public string Address { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        

        public List<RestaurantComments> Comments { get; set; }
        public List<RestaurantRating> Ratings { get; set; }
    }
}

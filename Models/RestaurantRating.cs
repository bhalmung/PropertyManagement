using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
   public class RestaurantRating
    {
       public int Id { get; set; }
        public String UserName { get; set; }
        public int Rating { get; set; }
        public DateTime RetingDate { get; set; }
        public int RestaurentId { get; set; }
        public Restaurant Restaurent { get; set; }
    }
}

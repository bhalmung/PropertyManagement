using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class RestaurentRating
    {
       public int Id { get; set; }
        public String UserName { get; set; }
        public int Rating { get; set; }
        public DateTime RetingDate { get; set; }
        public int RestaurentId { get; set; }
        public Restaurent Restaurent { get; set; }
    }
}

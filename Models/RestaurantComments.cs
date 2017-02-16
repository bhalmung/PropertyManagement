using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RestaurantComments
    {
        public int Id { get; set; }
        public string UserName { set; get; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
    }
}

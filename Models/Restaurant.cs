﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
   
   public class Restaurant
    {
          
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostCode { get; set; }

        

        public List<RestaurantComments> Comments { get; set; }
        public List<RestaurantRating> Ratings { get; set; }
    }
}

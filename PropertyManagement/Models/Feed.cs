using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class Feed
    {
        public int FeedId { get; set; }
        public string FeedUrl { get; set; }
        public DateTime FeedCreatedDate { get; set; }
        public DateTime FeedLastUpdateDate { get; set; }

        public int TotalProperty { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
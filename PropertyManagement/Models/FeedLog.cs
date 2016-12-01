using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class FeedLog
    {
        public Guid FeedlogId { get; set; }
        public int FeedID { get; set; }
        public DateTime ParsedDate { get; set; }
        public bool Success { get; set; }
        public DateTime NextParseTime { get; set; }

    }
}
using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PropertyManagement.BAL.Interfaces;

namespace PropertyManagement.BAL
{
    public class FeedLoggerRepository  : Repository<FeedLog>, IFeedLogger
    {
        public FeedLoggerRepository(DbContext context) : base(context)
        {
        }

        

    }
}
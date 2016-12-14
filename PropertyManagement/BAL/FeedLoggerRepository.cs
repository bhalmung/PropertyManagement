using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PropertyManagement.BAL
{
    public class FeedLoggerRepository : Repository<FeedLog>
    {
        public FeedLoggerRepository(DbContext context) : base(context)
        {
        }

        

    }
}
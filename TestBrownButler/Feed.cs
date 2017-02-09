using Informanagement.DotNetRssFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBrownButler
{
    public static class Feed
    {
        public static  RssFeed GetRssFeed()
        {
            var rss = new Informanagement.DotNetRssFeed.RssFeed("brownbutler");
            return rss;
        }
    }
}

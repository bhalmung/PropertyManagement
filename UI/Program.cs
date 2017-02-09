using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrownButler;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var FeedRss = Feed.GetRssFeed();
            
          var RSS=  FeedRss.GetRss(10, 500);
            var rssList = FeedRss.GetNews(13889);
            //13889

        }
    }
}

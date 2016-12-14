using Microsoft.VisualStudio.TestTools.UnitTesting;
using PropertyManagement.BAL;
using PropertyManagement.BAL.Exceptions;
using PropertyManagement.Tests.Controllers.Feeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Tests.Controllers
{
    [TestClass]
   public class FeedPareserTest
    {
        
        [TestMethod]
        public void FeedParser_CheckValidFeedURL_ReturnsFeedString()
        {
            var  feedParser = new TestFeed();
            var str = feedParser.FalkeGetStringFrmURL();
            StringAssert.Contains(str, "properties");
        }
        [TestMethod]
        [ExpectedException(typeof(FeedURLException), "URL is Empty")]
        public void FeedParser_CheckEmptyFeedURL_ThorwsFeedExceptionFeedString()
        {
            var feedParser = new TestFeedEmpty();

            var str = feedParser.FalkeGetStringFrmURL();

            
        }

        [TestMethod]
        [ExpectedException(typeof(FeedURLException), "URL is Empty")]
        public void FeedParser_CheckInvalidFeedURL_ThorwsFeedExceptionFeedString()
        {
            var feedParser = new TestFeedInvalidFeed();

            var str = feedParser.FalkeGetStringFrmURL();


        }
    }
}

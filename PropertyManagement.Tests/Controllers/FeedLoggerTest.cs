using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PropertyManagement.BAL;
using PropertyManagement.BAL.Interfaces;
using PropertyManagement.DB;
using PropertyManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Tests.Controllers
{
    [TestClass]
   public class FeedLoggerTest
    {
        [TestMethod]
        public void FeedLogger_AddFeedLog_AddFeedLog()
        {
            var context = new Mock<PropertyManagementContext>();
            var FeedLogger = new Mock<DbSet<FeedLog>>();

            FeedLogger.Setup(x=>x.Add(It.IsAny<FeedLog>())).Returns((FeedLog log)=>log);
            context.Setup(x => x.FeedLog).Returns(FeedLogger.Object);
         IFeedLoggerRepository logger = new FeedLoggerRepository(context.Object);
       
        }
    }
}

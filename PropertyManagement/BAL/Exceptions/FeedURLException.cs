using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.BAL.Exceptions
{
    public class FeedURLException:Exception
    {
        public string URL { get; set; }

        public FeedURLException(string URL,string Message):base(Message)
        {
            this.URL = URL;
        }
        public FeedURLException(string URL, string Message,Exception ex) : base(Message,ex)
        {
            this.URL = URL;
        }

    }
}
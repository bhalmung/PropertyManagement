using PropertyManagement.BAL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace PropertyManagement.BAL
{
    public abstract class FeedParserRepository
    {
        public abstract string URL { get;    }
        public FeedParserRepository()
        {

        }
        //Not Fully Implemented
        public  void Parse()
        {
            var feed = GetStringFrmURL();

        }

        //Get Get The string Contents from URL
        protected virtual string GetStringFrmURL()
        {
            string result = "";
            try
            {
               
                if (URLValid(URL))
                {
                    result = new WebClient().DownloadString(URL);
                }else
                {

                }
            }
            catch(FeedURLException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FeedURLException(URL,"Error While Downloading String From URL",ex);
            }
            return result;

        }
        protected virtual  bool URLValid (string URL)
        {
            var res = false;
            if (string.IsNullOrEmpty(URL))
            {
                res = false;
                throw new FeedURLException(URL, "URL is Empty");

            }else
            {
                res = true;
            }
             
                return res ;
        }
    }
}
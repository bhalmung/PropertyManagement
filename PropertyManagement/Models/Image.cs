using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class Image
    {
        public int PropertyID { get; set; }
        public int ImageID { get; set; }
        public string ImageName { get; set; }
        public string ImageURL { get; set; }
        public string ImageDescritpion { get; set; }
        public DateTime ImageSavedDate { get; set; }
        public DateTime ImageLastUpdatedDate { get; set; }
    }
}
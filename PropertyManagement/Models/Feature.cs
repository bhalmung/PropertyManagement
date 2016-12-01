using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class Feature
    {
        public int PropertyID { get; set; }
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }
        public string Description { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class Property
    {
        public string PropertyId { get; set; }
        public int Row { get; set; }
        public DateTime PropertyCreatedDate { get; set; }
        public DateTime PropertyLastUpdatedDate { get; set; }
        public string Description { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public ValueBy CoordinatesByValueBy { get; set; }
        public int? BedRoomCount { get; set; }
        public int? BathRoomCount { get; set; }


        public ICollection<Image> Images { get; set; }
        public ICollection<Feature> Feature { get; set; }

    }

    public enum ValueBy
    {
        Feed,
        GoogleMaps,
        Manual
    }
}
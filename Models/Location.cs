using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMapWebAPI.Models
{
    public class Location
    {
        public string City { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
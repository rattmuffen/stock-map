using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stock_map.Models
{
    public class Company
    {
        public string CompanyName { get; set;}
        public Location Location { get; set; }
        public string MarketSegment { get; set; }
    }
}
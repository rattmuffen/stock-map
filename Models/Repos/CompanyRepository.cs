using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using stock_map.Models;

namespace stock_map.Models.Repos
{
    public class CompanyRepository
    {
        private List<Company> Companies = new List<Company>();

        public CompanyRepository()
        {
            Company c1 =  new Company
                {
                    CompanyName = "Sectra",
                    Location = new Location
                    {
                        City = "Linköping",
                        Latitude = "58.39346",
                        Longitude = "15.557192"
                    },
                    MarketSegment = "MidCap"
                };

            Company c2 = new Company
            {
                CompanyName = "Ericsson",
                Location = new Location
                {
                    City = "Stockholm",
                    Latitude = "59.404682",
                    Longitude = "17.956033"
                },
                MarketSegment = "LargeCap"
            };
               
            Company c3 =   new Company
                {
                    CompanyName = "Gränges",
                    Location = new Location
                    {
                        City = "Stockholm",
                        Latitude= "59.404682",
                        Longitude = "17.956033"
                    },
                    MarketSegment = "MidCap"
                };

            Company c4 = new Company
            {
                CompanyName = "Bolinden",
                Location = new Location
                {
                    City = "Boliden",
                    Latitude = "64.862941",
                    Longitude = "20.386544"
                },
                MarketSegment = "LargeCap"
            };

            Company c5 = new Company
            {
                CompanyName = "Volvo",
                Location = new Location
                {
                    City = "Göteborg",
                    Latitude = "57.708870",
                    Longitude = "11.97456"
                },
                MarketSegment = "LargeCap"
            };

            Companies.Add(c1);
            Companies.Add(c2);
            Companies.Add(c3);
            Companies.Add(c4);
            Companies.Add(c5);
        }

        public List<Company> getAll()
        {
            return Companies;
        }
    }
}
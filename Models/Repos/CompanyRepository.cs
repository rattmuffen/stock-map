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
                    }
                };
               
            Company c2 =   new Company
                {
                    CompanyName = "Ericsson",
                    Location = new Location
                    {
                        City = "Stockholm",
                        Latitude= "59.404682",
                        Longitude = "17.956033"
                    }
                };

            Companies.Add(c1);
            Companies.Add(c2);
        }

        public List<Company> getAll()
        {
            return Companies;
        }
    }
}
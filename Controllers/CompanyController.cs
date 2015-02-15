using stock_map.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace stock_map.Controllers
{
    public class CompanyController : ApiController
    {
        public Company[] Get()
        {
            return new Company[]
            {
                new Company
                {
                    CompanyName = "Sectra",
                    Location = new Location
                    {
                        City = "Linköping",
                        Latitude = "58.39346",
                        Longitude = "15.557192"
                    }
                },
                new Company
                {
                    CompanyName = "Ericsson",
                    Location = new Location
                    {
                        City = "Stockholm",
                        Latitude= "59.404682",
                        Longitude = "17.956033"
                    }
                }
            };
        }
    }
}

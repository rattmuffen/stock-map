using stock_map.Models;
using stock_map.Models.Repos;
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
        private CompanyRepository repo = new CompanyRepository();

        public List<Company> GetAll()
        {
            return repo.getAll();
        }
    }
}

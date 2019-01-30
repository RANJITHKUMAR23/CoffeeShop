using CoffeeShop.Models.Models;
using CoffeeShop.Service;
using CoffeeShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoffeeShop.Web.Controllers
{
    [RoutePrefix("api/Company")]
    public class CompanyController : ApiController
    {
        private ICompanyService companyService = new CompanyService();

        [Route("GetAll")]
        public IQueryable<Company> GetAll()
        {
            var result = companyService.GetAllCompanies();
            return result;
        }
    }
}

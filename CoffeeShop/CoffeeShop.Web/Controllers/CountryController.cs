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
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        private ICountryService countryService = new CountryService();

        [Route("Save")]
        [HttpPost]
        public Country Save(Country entity)
        {
            var result = countryService.Save(entity);
            return result;
        }


        [Route("Update")]
        [HttpPost]
        public Country Update(Country entity)
        {
            var result = countryService.Update(entity);
            return result;
        }

        [Route("Delete")]
        [HttpGet]
        public bool Delete(int id)
        {
            var result = countryService.Delete(id);
            return result;
        }
    }
}

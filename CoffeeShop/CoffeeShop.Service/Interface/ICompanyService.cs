using CoffeeShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Service.Interface
{
    public interface ICompanyService
    {
        IQueryable<Company> GetAllCompanies();
    }
}

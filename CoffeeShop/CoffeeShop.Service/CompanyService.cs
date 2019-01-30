using CoffeeShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Models.Models;
using CoffeeShop.Models.DatabaseContext;

namespace CoffeeShop.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public IQueryable<Company> GetAllCompanies()
        {
            try
            {
                var result = _context.Company.AsQueryable();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

using CoffeeShop.Models.Models;
using System.Linq;

namespace CoffeeShop.Service.Interface
{
    public interface ICountryService
    {
        IQueryable<Country> GetAll();
        Country GetById(int id);
        Country Save(Country entity);
        Country Update(Country entity);
        bool Delete(int id);
    }
}

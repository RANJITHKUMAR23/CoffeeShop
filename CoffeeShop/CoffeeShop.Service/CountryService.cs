using CoffeeShop.Models.DatabaseContext;
using CoffeeShop.Models.Models;
using CoffeeShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Service
{
    public class CountryService : ICountryService
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public bool Delete(int id)
        {
            try
            {
                var result = _context.Country.Where(x => x.Id == id).FirstOrDefault();
                _context.Country.Remove(result);
                var objResult = _context.SaveChanges();
                if (objResult == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                // TODO: To be handle  exception
                throw;
            }
        }

        public IQueryable<Country> GetAll()
        {
            try
            {
                var result = _context.Country.AsQueryable();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Country GetById(int id)
        {
            try
            {
                var result = _context.Country.FirstOrDefault(x => x.Id == id);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Country Save(Country entity)
        {
            try
            {
                var result = _context.Country.Add(entity);
                _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Country Update(Country entity)
        {
            try
            {
                if (entity.Id == 0)
                {
                    return null;
                }
                var oldObj = _context.Country.FirstOrDefault(x => x.Id == entity.Id);
                _context.Entry(oldObj).State = EntityState.Modified;
                _context.SaveChanges();
                var result = _context.Country.FirstOrDefault(x => x.Id == entity.Id);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
      
    }
}

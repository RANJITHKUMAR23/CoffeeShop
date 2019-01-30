using CoffeeShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Map
{
   public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Name).IsRequired().HasMaxLength(100);
            Property(m => m.AlaisName);
            Property(m => m.Description);
            HasMany(m => m.State).WithRequired().HasForeignKey(s => s.CountryId);


        }
    }
}

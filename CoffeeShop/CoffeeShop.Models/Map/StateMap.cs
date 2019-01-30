using CoffeeShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Map
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Name).IsRequired().HasMaxLength(100);
            Property(m => m.AlaisName);
            Property(m => m.Description);
           
        }

    }
}

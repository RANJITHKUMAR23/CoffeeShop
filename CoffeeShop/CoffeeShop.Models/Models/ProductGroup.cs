using CoffeeShop.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Models
{
   public class ProductGroup : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}

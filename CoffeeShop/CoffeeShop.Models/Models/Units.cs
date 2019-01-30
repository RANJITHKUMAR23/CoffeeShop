using CoffeeShop.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Models
{
   public class Units : Entity<int>
    {
        public Units()
        {
            this.Product = new HashSet<Product>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}

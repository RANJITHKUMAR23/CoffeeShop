using CoffeeShop.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Models
{
    public class Currency : Entity<int>
    {
        public Currency()
        {
            this.Company = new HashSet<Company>();
        }
        public string Name { get; set; }
        public string AlaisName { get; set; }
        public string Symbol { get; set; }
        public int NoOfDecimalPlaces { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Company> Company { get; set; }
    }
}

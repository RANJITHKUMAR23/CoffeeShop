using CoffeeShop.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Models
{
    public class Country : Entity<int>
    {
        public Country()
        {
            this.State = new HashSet<State>();

        }
        public string Name { get; set; }
        public string AlaisName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<State> State { get; set; }
    }
}

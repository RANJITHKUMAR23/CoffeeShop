using CoffeeShop.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Models
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public int UnitId { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalesPrice { get; set; }
        public bool IsSellable { get; set; }
        public bool IsPurchasable { get; set; }
        public bool IsActive { get; set; }
        public bool IsBillOfMaterial { get; set; }
        public virtual Units Unit { get; set; }
        
    }
}

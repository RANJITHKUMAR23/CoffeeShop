using CoffeeShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Map
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Name).IsRequired().HasMaxLength(100);
           
            Property(m => m.PurchasePrice).IsRequired();
            Property(m => m.SalesPrice).IsRequired();
            Property(m => m.IsSellable).IsRequired();
            Property(m => m.IsPurchasable).IsRequired();
            Property(m => m.IsActive).IsRequired();
            Property(m => m.IsBillOfMaterial).IsRequired();

        }
    }
}

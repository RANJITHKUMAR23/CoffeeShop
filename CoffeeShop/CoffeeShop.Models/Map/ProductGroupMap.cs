using CoffeeShop.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Map
{
    public class ProductGroupMap : EntityTypeConfiguration<ProductGroup>
    {
        public ProductGroupMap()
            {
            HasKey(m => m.Id);
            Property(m => m.Name).IsRequired().HasMaxLength(100);
            Property(m => m.Description);
            HasMany(m => m.Product).WithRequired().HasForeignKey(s => s.ProductGroupId);
        }
    }
}

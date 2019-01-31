using CoffeeShop.Models.Common;
using System.Collections.Generic;

namespace CoffeeShop.Models.Models
{
    public class Company : AuditableEntity<int>
    {
        public Company()
        {
            this.Units = new HashSet<Units>();
            this.ProductGroup = new HashSet<ProductGroup>();
            this.Product = new HashSet<Product>();

        }

        public string Name { get; set; }
        public string AliasName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public int CurrencyId { get; set; }
        public int Zipcode { get; set; }
        public int PhoneNumber { get; set; }
        public int MobileNumber { get; set; }
        public string Website { get; set; }
        public int GstNo { get; set; }
        public string Logo { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<Units> Units { get; set; }
        public virtual ICollection<ProductGroup> ProductGroup { get; set; }
        public virtual ICollection<Product> Product { get; set; }

    } 
}

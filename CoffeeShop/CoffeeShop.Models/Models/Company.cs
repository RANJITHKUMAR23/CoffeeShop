using CoffeeShop.Models.Common;

namespace CoffeeShop.Models.Models
{
    public class Company : AuditableEntity<int>
    {
        public Company()
        {
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
    } 
}

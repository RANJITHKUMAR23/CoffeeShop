using CoffeeShop.Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace CoffeeShop.Models.Map
{
    public class CompanyMap: EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            HasKey(m => m.Id);
            Property(m => m.Name).IsRequired().HasMaxLength(500);
            Property(m => m.AliasName).IsOptional().HasMaxLength(500);
            Property(m => m.Address).IsOptional().HasMaxLength(1000);
            Property(m => m.City).IsRequired().HasMaxLength(200);
            Property(m => m.StateId).IsRequired();
            Property(m => m.CountryId).IsRequired();
            Property(m => m.Zipcode).IsRequired();
            Property(m => m.CurrencyId).IsRequired();
            Property(m => m.PhoneNumber).IsRequired();
            Property(m => m.MobileNumber).IsRequired();
            Property(m => m.GstNo).IsRequired();
            Property(m => m.Website).IsOptional().HasMaxLength(500);
            Property(m => m.Logo).IsOptional().HasMaxLength(4000);
            HasRequired(m => m.CreatedApplicationUser).WithMany().HasForeignKey(m => m.CreatedBy).WillCascadeOnDelete(false);
            HasOptional(m => m.UpdatedApplicationUser).WithMany().HasForeignKey(m => m.UpdatedBy).WillCascadeOnDelete(false);

        }
    }
}

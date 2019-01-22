using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models.Common
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        [ScaffoldColumn(false)]
        public DateTimeOffset CreatedDate { get; set; }
        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTimeOffset? UpdatedDate { get; set; }
        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; }
        //public ApplicationUser CreatedApplicationUser { get; set; }
        //public ApplicationUser UpdatedApplicationUser { get; set; }
    }

}

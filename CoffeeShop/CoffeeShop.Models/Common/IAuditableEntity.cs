using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Common
{
    public interface IAuditableEntity
    {
        DateTimeOffset CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }

    }
}

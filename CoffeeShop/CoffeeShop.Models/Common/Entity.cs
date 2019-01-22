using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.Common
{
    public abstract class IEntity
    {

    }

    public abstract class Entity<T> : IEntity, IEntity<T>
    {
        public virtual T Id { get; set; }
    }

    public abstract class EntityResult<T> : IEntity
    {
        public virtual T Entity { get; set; }
    }

}

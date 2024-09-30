using MieShop.Commons.Base;
using MieShop.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class ShippingMethod : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public virtual ICollection<ShippingMethodProduct>? ShippingMethodProducts { get; set; }
    }
}

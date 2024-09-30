using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class ShippingMethodProduct : BaseEntity<Guid>, IActivatable
    {
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public Guid ShippingMethodId { get; set; }
        public virtual ShippingMethod? ShippingMethod { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public bool IsActive { get; set; } = false;
        public virtual ICollection<Bill>? Bills { get; set; }
    }
}

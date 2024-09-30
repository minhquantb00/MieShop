using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class EventProduct : BaseEntity<Guid>
    {
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public Guid DiscountEventId { get; set; }
        public virtual DiscountEvent? DiscountEvent { get; set; }
    }
}

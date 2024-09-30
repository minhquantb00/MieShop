using MieShop.Commons.Base;
using MieShop.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class DiscountEvent : BaseEntity<Guid>
    {
        public string EventName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public double DiscountPercent { get; set; }
        public Enumerate.DiscountEventStatus DiscountEventStatus { get; set; } = Enumerate.DiscountEventStatus.CoHieuLuc;
        public virtual ICollection<EventProduct>? EventProducts { get; set; }
    }
}

using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Cart : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<CartItem>? CartItems { get; set; }
    }
}

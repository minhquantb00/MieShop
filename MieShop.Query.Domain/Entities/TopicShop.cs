using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class TopicShop : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public virtual ICollection<Shop>? Shops { get; set; }
    }
}

using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Property : BaseEntity<Guid>
    {
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PropertyDetail>? PropertyDetails { get; set; }
    }
}

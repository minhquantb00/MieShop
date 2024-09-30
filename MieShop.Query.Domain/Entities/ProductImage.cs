using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class ProductImage : BaseEntity<Guid>
    {
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<PropertyDetail>? PropertyDetails { get; set; }
    }
}

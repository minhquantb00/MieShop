using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class PropertyDetail : BaseEntity<Guid>
    {
        public Guid PropertyId { get; set; }
        public virtual Property? Property { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid ProductImageId { get; set; }
        public virtual ProductImage? ProductImage { get; set; }
        public virtual ICollection<ProductDetailPropertyDetail>? ProductDetailPropertyDetails { get; set; }
    }
}

using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class ProductDetailPropertyDetail : BaseEntity<Guid>
    {
        public Guid ProductDetailId { get; set; }
        public virtual ProductDetail? ProductDetail { get; set; }
        public Guid PropertyDetailId { get; set; }
        public virtual PropertyDetail? PropertyDetail { get; set; }
    }
}

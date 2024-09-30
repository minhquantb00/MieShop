using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class FavoriteProduct : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public Guid ProductDetailId { get; set; }
        public virtual ProductDetail? ProductDetail { get; set; }
    }
}

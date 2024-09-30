using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class CartItem : BaseEntity<Guid>
    {
        public Guid CartId { get; set; }
        public virtual Cart? Cart { get; set; }
        public Guid ProductDetailId { get; set; }
        public virtual ProductDetail? ProductDetail { get; set; }   
        public int Quantity { get; set; }
        public double UnitPrice {  get; set; } 
    }
}

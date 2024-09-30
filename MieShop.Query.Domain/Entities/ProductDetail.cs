using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class ProductDetail : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public int Quantity { get; set; } = 0;
        public double Price { get; set; }
        public int SoldQuantity { get; set; } = 0;
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public double PriceAfterDiscount { get; set; }
        public int ErrorQuantity { get; set; } = 0;
        public int InventoryNumber { get; set; } = 0;
        public Guid ParentId { get; set; }
        public virtual ProductDetail? Parent { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        public virtual ICollection<FavoriteProduct>? FavoriteProducts { get; set; }
        public virtual ICollection<CartItem>? CartItems { get; set; }
    }
}

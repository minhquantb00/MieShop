using MieShop.Commons.Base;
using MieShop.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Product : BaseEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int SoldQuantity { get; set; } = 0;
        public string ImageUrl { get; set; }
        public int ReturnQuantity { get; set; } = 0;
        public double PriceAfterDiscount { get; set; }
        public int ErrorQuantity { get; set; } = 0;
        public double AverageRating { get; set; } = 0;
        public Enumerate.ProductStatus ProductStatus { get; set; } = Enumerate.ProductStatus.DangMoBan;
        public int InventoryNumber {  get; set; } = 0;
        public Guid CollectionId { get; set; }
        public virtual Collection? Collection { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public Guid TopicProductId { get; set; }
        public virtual TopicProduct? TopicProduct { get; set; }
        public Guid ShopId { get; set; }
        public virtual Shop? Shop { get; set; }
        public virtual ICollection<EventProduct>? EventProducts { get; set; }
        public virtual ICollection<Property>? Properties { get; set; }
        public virtual ICollection<ProductImage>? ProductImages { get; set; }
        public virtual ICollection<ProductReview>? ProductReviews { get; set; }
        public virtual ICollection<ShippingMethodProduct>? ShippingMethodProducts { get; set; }
    }
}

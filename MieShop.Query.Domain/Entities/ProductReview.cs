using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class ProductReview : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int NumberOfStar { get; set; }
        public DateTime ReviewTime { get; set; }

    }
}

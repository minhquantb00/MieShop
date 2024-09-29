using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Shop : BaseEntity<Guid>, IDeleteable
    {
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public Guid TopicId { get; set; }
        public virtual TopicShop? Topic {  get; set; }
        public double ToltalRate { get; set; } = 0;
        public int NumberOfProductSold { get; set; } = 0;
        public int NumerOfFollower { get; set; } = 0;
        public double CancellationRate { get; set; } = 0;
        public double ReturnRate { get; set; } = 0; 
        public string Description { get; set; }
        public int NumberOfProducts {  get; set; } = 0;
        public string AddressShop { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

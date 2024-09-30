using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Collection : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public int NumberOfProducts { get; set; } = 0;
    }
}

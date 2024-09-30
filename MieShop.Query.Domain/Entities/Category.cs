using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public int NumberOfProducts { get; set; } = 0;
    }
}

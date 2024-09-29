using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Role : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserRole>? UserRoles { get; set; }
    }
}

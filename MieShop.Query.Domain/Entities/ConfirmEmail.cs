using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class ConfirmEmail : BaseEntity<Guid>
    {
        public string ConfirmCode { get; set; }
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public DateTime? ExpiredTime { get; set; }
        public bool IsConfirmed { get; set; } = false;
    }
}

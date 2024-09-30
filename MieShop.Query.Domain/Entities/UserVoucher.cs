using MieShop.Commons.Base;
using MieShop.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class UserVoucher : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public Guid VoucherId { get; set; }
        public virtual Voucher? Voucher { get; set; }
        public DateTime ExpiredTime { get; set; }
        public double DiscountPercent { get; set; }
        public Enumerate.UserVoucherStatus UserVoucherStatus { get; set; } = Enumerate.UserVoucherStatus.ChuaSuDung;
        public virtual ICollection<Bill>? Bills { get; set; }
    }
}

using MieShop.Commons.Base;
using MieShop.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Voucher : BaseEntity<Guid>
    {
        public string VoucherCode { get; set; }
        public string VoucherName { get; set; }
        public double DiscountPercent { get; set; }
        public DateTime ExpiredTime { get; set; }
        public Enumerate.VoucherStatus VoucherStatus { get; set; } = Enumerate.VoucherStatus.ChuaCoHieuLuc;
        public virtual ICollection<UserVoucher>? UserVouchers { get; set; }
    }
}

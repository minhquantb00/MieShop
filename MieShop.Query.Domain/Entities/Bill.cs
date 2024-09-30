using MieShop.Commons.Base;
using MieShop.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class Bill : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public Guid ShippingMethodProductId { get; set; }
        public virtual ShippingMethodProduct? ShippingMethodProduct { get; set; }
        public string Address { get; set; }
        public string TradingCode { get; set; }
        public Guid PaymentMethodId { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public DateTime? PaymentTime { get; set; }
        public double TotalPriceBeforeDiscount { get; set; }
        public Enumerate.BillStatus BillStatus { get; set; } = Enumerate.BillStatus.ChuaThanhToan;
        public string Note { get; set; }
        public string? ReasonForRefusal { get; set; }
        public double TotalPriceAfterDiscount { get; set; }
        public Guid UserVoucherId { get; set; }
        public virtual UserVoucher? UserVoucher { get; set; }
        public double ShippingFee { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MieShop.Commons.Enums
{
    public class Enumerate
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum Gender
        {
            KhongXacDinh = 0,
            Nam = 1,
            Nu = 2
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum VoucherStatus
        {
            ChuaCoHieuLuc = 0,
            CoTheSuDung = 1,
            HetHan = 2
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum UserVoucherStatus
        {
            ChuaSuDung = 0,
            HetHan = 1,
            DaSuDung = 2
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum DiscountEventStatus
        {
            CoHieuLuc = 0,
            DaSuDung = 1,
            HetHan = 2
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ProductStatus
        {
            HetHang = 0,
            ConHang = 1,
            DangMoBan = 2
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ShippingMethodStatus
        {
            ChuaKichHoat = 0,
            DaKichHoat = 1
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum BillStatus
        {
            ChuaThanhToan = 0,
            DaThanhToan = 1,
            HuyDon = 2
            
        }
    }
}

using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities
{
    public class UserSession : BaseEntity<Guid>, IActivatable
    {
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public string SessionToken { get; set; }
        public string IpAddress { get; set; }
        public string DeviceName { get; set; }
        public string BrowserName { get; set; }
        public string GeoLocation { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LastActivitpuyTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsRevoked { get; set; }
        public string DeviceFingerPrint { get; set; }
        public DateTime SessionExpiration {  get; set; }
    }
}

using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities.Media
{
    public class MediaStorage : BaseEntity<Guid>
    {
        public byte[] Data { get; set; }
    }
}

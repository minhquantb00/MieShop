using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Commons.Base
{
    public class BaseEntity<TKey> : IEntity<TKey>, IHasCreationTime, IHasModificationTime
    {
        public TKey Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public object[] GetKeys()
        {
            return new object[] {Id};
        }
    }
}

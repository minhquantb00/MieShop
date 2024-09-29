using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Cores.Consumers
{
    public interface IEventConsumer
    {
        void Consume(string topic);
    }
}

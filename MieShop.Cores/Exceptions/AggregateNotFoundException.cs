﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Cores.Exceptions
{
    public class AggregateNotFoundException : Exception
    {
        public AggregateNotFoundException(string message) : base(message)
        {

        }
    }
}

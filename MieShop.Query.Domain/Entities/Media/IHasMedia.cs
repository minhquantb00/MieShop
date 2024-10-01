﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities.Media
{
    public interface IHasMedia
    {
        int? MediaStorageId { get; set; }
        MediaStorage MediaStorage { get; set; }
    }
}

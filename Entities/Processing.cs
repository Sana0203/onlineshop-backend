using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class Processing : OrderStatus
    {
        public DateTime WaitingDuration { get; set; }
        public string? Description { get; set; }
    }
}
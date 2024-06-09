using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class Pending : OrderStatus
    {
        public required string Reason { get; set; }
    }
}
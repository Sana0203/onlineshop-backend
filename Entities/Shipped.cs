using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class Shipped : OrderStatus
    {
        public string? TarckLocation { get; set; }
        public DateTime? ETA { get; set; }
    }
}
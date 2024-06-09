using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class OrderStatus : Entity
    {
        public string Status { get; set; } = string.Empty;
        public DateTime? Date { get; set; }
    }
}
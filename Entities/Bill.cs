using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class Bill : Entity
    {
        public Order? Order { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public double TotalAmount { get; set; }
    }
}
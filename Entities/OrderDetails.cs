using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class OrderDetails :Entity
    {
        public Order? Order { get; set; }
        public int OrderId { get; set; }
        public Product? Product { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? UnitPrice { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class Order : Entity
    {
        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public int OrderStatusId { get; set; }
    }
}
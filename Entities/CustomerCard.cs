using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class CustomerCard : Entity
    {
        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public int? SecurityCode { get; set; }
        public DateTime? ExpiryDate { get; set; }

    }
}
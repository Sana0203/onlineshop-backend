using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class Payment : Entity
    {
        public  Bill? Bill { get; set; }
        public int BillId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public CustomerCard? CustomerCard { get; set; }
        public int CustomerCardId { get; set; }
    }
}
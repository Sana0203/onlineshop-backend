using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopBackend.Entities;

namespace OnlineShopBackend.DB
{
    public class MyOnlineShopDB : DbContext
    {
        //creating database sets for all the relations for online shop system
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<ProductCategories> Categories { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shipped> Shippeds { get; set; }
        public DbSet<Pending> Pendings { get; set; }
        public DbSet<Processing> Processings { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<CustomerCard> CustomerCards { get; set; }


        public MyOnlineShopDB(DbContextOptions<MyOnlineShopDB> options) : base(options)
        {

        }

    }
}
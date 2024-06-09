using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopBackend.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public double Rating { get; set; }
        public ProductCategories? ProductCategories { get; set; } 
        public int ProductCategoriesId { get; set; }
    }
}
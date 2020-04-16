using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public List<Product_Category> Product_Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}

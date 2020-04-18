using LegitProduct.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.Product.Dtos
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public decimal Price { set; get; }
        public string Description { get; set; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public List<Product_Category> Product_Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public AppUser AppUser { get; set; }
    }
}

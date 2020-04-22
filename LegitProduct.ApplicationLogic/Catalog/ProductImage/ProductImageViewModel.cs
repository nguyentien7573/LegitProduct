using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.ProductImage
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

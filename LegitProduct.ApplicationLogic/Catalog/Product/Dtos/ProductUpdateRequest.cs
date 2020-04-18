using LegitProduct.Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.Product.Dtos
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { set; get; }
        public string Description { get; set; }
        public IFormFile ThumbnailImage { get; set; }
        public AppUser User { get; set; }
    }
}

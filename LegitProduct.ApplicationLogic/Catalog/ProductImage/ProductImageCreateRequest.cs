using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.ProductImage
{
    public class ProductImageCreateRequest
    {
        public bool IsDefault { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}

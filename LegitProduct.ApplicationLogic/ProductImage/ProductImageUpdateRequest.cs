﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.ProductImage
{
    public class ProductImageUpdateRequest
    {
        public int Id { get; set; }
        public bool IsDefault { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
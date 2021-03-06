﻿using Microsoft.AspNetCore.Http;
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

    public class ProductImageUpdateRequest
    {
        public int Id { get; set; }
        public bool IsDefault { get; set; }
        public IFormFile ImageFile { get; set; }
    }

    public class ProductImageViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

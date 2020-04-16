﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ImagePath { get; set; }

        public bool IsDefault { get; set; }

        public DateTime DateCreated { get; set; }

        public Product Product { get; set; }
    }
}

using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{ 
    public partial class ProductImage : BaseEntity
    {
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public bool IsDefault { get; set; }

        public virtual Product Product { get; set; }
    }
}

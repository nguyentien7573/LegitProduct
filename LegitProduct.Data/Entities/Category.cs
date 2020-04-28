using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int? ParentId { get; set; }
        public int Status { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}

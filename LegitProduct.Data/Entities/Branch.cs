using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class Branch : BaseEntity
    {
        public Branch()
        {
            ProductBranches = new HashSet<ProductBranch>();
        }
       
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<ProductBranch> ProductBranches { get; set; }
    }
}

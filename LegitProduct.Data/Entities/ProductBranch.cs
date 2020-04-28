using LegitProduct.Data.Entities.Common;
using System;

namespace LegitProduct.Data.Entities
{
    public class ProductBranch : BaseEntity
    {
        public int ProductId { get; set; }
        public int BranchId { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Product Product { get; set; }
    }
}

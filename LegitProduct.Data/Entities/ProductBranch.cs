using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class ProductBranch
    {
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Product Product { get; set; }
    }
}

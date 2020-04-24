﻿using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Branch
    {
        public Branch()
        {
            ProductBranches = new HashSet<ProductBranch>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<ProductBranch> ProductBranches { get; set; }
    }
}

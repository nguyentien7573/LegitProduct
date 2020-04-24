using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Category
    {
        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}

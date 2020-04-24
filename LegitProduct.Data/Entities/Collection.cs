using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Collection
    {
        public Collection()
        {
            CollectionProducts = new HashSet<CollectionProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<CollectionProduct> CollectionProducts { get; set; }
    }
}

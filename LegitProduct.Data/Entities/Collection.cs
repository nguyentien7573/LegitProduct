using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class Collection : BaseEntity
    {
        public Collection()
        {
            CollectionProducts = new HashSet<CollectionProduct>();
        }
     
        public string Desciption { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<CollectionProduct> CollectionProducts { get; set; }
    }
}

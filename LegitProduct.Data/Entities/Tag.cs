using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{ 
    public class Tag : BaseEntity
    {
        public Tag()
        {
            PostTags = new HashSet<PostTag>();
        }

        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{ 
    public partial class Tag
    {
        public Tag()
        {
            PostTags = new HashSet<PostTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}

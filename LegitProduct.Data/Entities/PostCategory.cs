using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class PostCategory
    {
        public PostCategory()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedUserId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}

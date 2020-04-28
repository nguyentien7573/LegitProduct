using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class Post : BaseEntity
    {
        public Post()
        {
            PostComments = new HashSet<PostComment>();
            PostTags = new HashSet<PostTag>();
        }

        public Guid AppUserId { get; set; }
        public string Summary { get; set; }
        public int IsActive { get; set; }
        public int PostCategoryId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual PostCategory PostCategory { get; set; }
        public virtual ICollection<PostComment> PostComments { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}

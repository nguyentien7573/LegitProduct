using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Post
    {
        public Post()
        {
            PostComments = new HashSet<PostComment>();
            PostTags = new HashSet<PostTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PostContent { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid AppUserId { get; set; }
        public string Summary { get; set; }
        public int IsActive { get; set; }
        public int PostCategoryId { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedUserId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual PostCategory PostCategory { get; set; }
        public virtual ICollection<PostComment> PostComments { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}

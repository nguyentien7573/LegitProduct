using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class PostComment
    {
        public int Id { get; set; }
        public string CommentContent { get; set; }
        public int PostId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedUserId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Post Post { get; set; }
    }
}

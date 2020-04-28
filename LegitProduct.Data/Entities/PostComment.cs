using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class PostComment : BaseEntity
    {
        public string CommentContent { get; set; }
        public int PostId { get; set; }
        
        public virtual Post Post { get; set; }
    }
}

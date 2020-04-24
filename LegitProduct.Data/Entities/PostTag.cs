using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class PostTag
    {
        public int TagId { get; set; }
        public int PostId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Post Post { get; set; }
        public virtual Tag Tag { get; set; }
    }
}

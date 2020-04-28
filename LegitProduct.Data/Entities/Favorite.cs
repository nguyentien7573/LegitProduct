using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class Favorite : BaseEntity
    {
        public int ProductId { get; set; }
        public Guid AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual Product Product { get; set; }
    }
}

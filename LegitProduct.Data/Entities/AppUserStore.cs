using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class AppUserStore : BaseEntity
    {
        public int StoreId { get; set; }
        public Guid AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual Store Store { get; set; }
    }
}

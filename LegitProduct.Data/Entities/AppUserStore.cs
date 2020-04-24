using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class AppUserStore
    {
        public int StoreId { get; set; }
        public Guid AppUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual Store Store { get; set; }
    }
}

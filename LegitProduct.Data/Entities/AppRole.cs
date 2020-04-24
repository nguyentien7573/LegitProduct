using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}

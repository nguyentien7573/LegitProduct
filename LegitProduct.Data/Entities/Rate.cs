using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Rate
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Feedback { get; set; }
        public int ProductId { get; set; }
        public Guid AppUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual Product Product { get; set; }
    }
}

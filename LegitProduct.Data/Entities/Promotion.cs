using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Promotion
    {
        public Promotion()
        {
            PromotionProducts = new HashSet<PromotionProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public double? DiscountValue { get; set; }
        public int? DiscountValueType { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<PromotionProduct> PromotionProducts { get; set; }
    }
}

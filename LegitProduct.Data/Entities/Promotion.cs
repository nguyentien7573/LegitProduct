using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class Promotion : BaseEntity
    {
        public Promotion()
        {
            PromotionProducts = new HashSet<PromotionProduct>();
        }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public double? DiscountValue { get; set; }
        public int? DiscountValueType { get; set; }
        public int Status { get; set; }

        public virtual ICollection<PromotionProduct> PromotionProducts { get; set; }
    }
}

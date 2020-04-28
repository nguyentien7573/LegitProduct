using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class ProductPrice : BaseEntity
    {
        public ProductPrice()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public int? AttributeValueId1 { get; set; }
        public int? AttributeValueId2 { get; set; }
        public decimal Price { get; set; }
        public decimal PriceSell { get; set; }

        public virtual AttributeValue AttributeValueId1Navigation { get; set; }
        public virtual AttributeValue AttributeValueId2Navigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

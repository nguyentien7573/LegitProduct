using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class ProductPrice
    {
        public ProductPrice()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? AttributeValueId1 { get; set; }
        public int? AttributeValueId2 { get; set; }
        public decimal Price { get; set; }
        public decimal PriceSell { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual AttributeValue AttributeValueId1Navigation { get; set; }
        public virtual AttributeValue AttributeValueId2Navigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

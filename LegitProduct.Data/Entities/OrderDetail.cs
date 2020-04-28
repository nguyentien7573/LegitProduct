using LegitProduct.Data.Entities.Common;
using System;

namespace LegitProduct.Data.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int? ProductPriceId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductPrice ProductPrice { get; set; }
    }
}

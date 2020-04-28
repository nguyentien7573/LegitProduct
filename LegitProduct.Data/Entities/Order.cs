using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{     
    public class Order : BaseEntity
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public DateTime OrderDate { get; set; }
        public Guid AppUserId { get; set; }
        public string ShipNameMethod { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public int AppUserAddressId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUserAddress AppUserAddress { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

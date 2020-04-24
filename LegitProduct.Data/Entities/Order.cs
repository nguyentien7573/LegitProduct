using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{     
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid AppUserId { get; set; }
        public string ShipNameMethod { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public int AppUserAddressId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUserAddress AppUserAddress { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

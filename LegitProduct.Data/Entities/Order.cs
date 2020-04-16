using LegitProduct.Data.ObjectEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Entities
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public Guid UserId { set; get; }
        public string ShipNameMethod { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public OrderStatus Status { set; get; }

        public List<OrderDetail> OrderDetails { get; set; }

        public AppUser AppUser
        {
            get; set;
        }
    }
}

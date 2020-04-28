using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class AppUserAddress : BaseEntity
    {
        public AppUserAddress()
        {
            Orders = new HashSet<Order>();
        }
        public string Address { get; set; }
        public int LocationProvinceId { get; set; }
        public int LocationDistrictId { get; set; }
        public int LocationWardId { get; set; }
        public int? LocationVillageId { get; set; }
        public Guid AppUserId { get; set; }
        public string PhoneNumber { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual LocationDistrict LocationDistrict { get; set; }
        public virtual LocationProvince LocationProvince { get; set; }
        public virtual LocationVillage LocationVillage { get; set; }
        public virtual LocationWard LocationWard { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

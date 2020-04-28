using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class LocationDistrict : BaseEntity
    {
        public LocationDistrict()
        {
            AppUserAddresses = new HashSet<AppUserAddress>();
            LocationWard = new HashSet<LocationWard>();
            Stores = new HashSet<Store>();
        }
        public int LocationProvinceId { get; set; }

        public virtual LocationProvince LocationProvince { get; set; }
        public virtual ICollection<AppUserAddress> AppUserAddresses { get; set; }
        public virtual ICollection<LocationWard> LocationWard { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}

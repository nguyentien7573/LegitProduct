using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class LocationProvince : BaseEntity
    {
        public LocationProvince()
        {
            AppUserAddresses = new HashSet<AppUserAddress>();
            LocationDistrict = new HashSet<LocationDistrict>();
            Stores = new HashSet<Store>();
        }
     
        public virtual ICollection<AppUserAddress> AppUserAddresses { get; set; }
        public virtual ICollection<LocationDistrict> LocationDistrict { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}

using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class LocationWard : BaseEntity
    {
        public LocationWard()
        {
            AppUserAddresses = new HashSet<AppUserAddress>();
            LocationVillage = new HashSet<LocationVillage>();
            Stores = new HashSet<Store>();
        }
        public int LocationDistrictId { get; set; }
       
        public virtual LocationDistrict LocationDistrict { get; set; }
        public virtual ICollection<AppUserAddress> AppUserAddresses { get; set; }
        public virtual ICollection<LocationVillage> LocationVillage { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}

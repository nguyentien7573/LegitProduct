using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class LocationVillage : BaseEntity
    {
        public LocationVillage()
        {
            AppUserAddresses = new HashSet<AppUserAddress>();
            Stores = new HashSet<Store>();
        }
        public int LocationWardId { get; set; }
        public virtual LocationWard LocationWard { get; set; }
        public virtual ICollection<AppUserAddress> AppUserAddresses { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}

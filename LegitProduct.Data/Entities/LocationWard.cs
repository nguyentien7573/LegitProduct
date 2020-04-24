using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class LocationWard
    {
        public LocationWard()
        {
            AppUserAddresses = new HashSet<AppUserAddress>();
            LocationVillage = new HashSet<LocationVillage>();
            Stores = new HashSet<Store>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int LocationDistrictId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual LocationDistrict LocationDistrict { get; set; }
        public virtual ICollection<AppUserAddress> AppUserAddresses { get; set; }
        public virtual ICollection<LocationVillage> LocationVillage { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class LocationDistrict
    {
        public LocationDistrict()
        {
            AppUserAddresses = new HashSet<AppUserAddress>();
            LocationWard = new HashSet<LocationWard>();
            Stores = new HashSet<Store>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int LocationProvinceId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual LocationProvince LocationProvince { get; set; }
        public virtual ICollection<AppUserAddress> AppUserAddresses { get; set; }
        public virtual ICollection<LocationWard> LocationWard { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Store
    {
        public Store()
        {
            AppUserStores = new HashSet<AppUserStore>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string BusinessLicense { get; set; }
        public string TaxCode { get; set; }
        public int? Status { get; set; }
        public int? IsLegit { get; set; }
        public string Address { get; set; }
        public int? LocationProvinceId { get; set; }
        public int? LocationDistrictId { get; set; }
        public int? LocationWardId { get; set; }
        public int? LocationVillageId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual LocationDistrict LocationDistrict { get; set; }
        public virtual LocationProvince LocationProvince { get; set; }
        public virtual LocationVillage LocationVillage { get; set; }
        public virtual LocationWard LocationWard { get; set; }
        public virtual ICollection<AppUserStore> AppUserStores { get; set; }
    }
}

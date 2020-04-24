using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class AttributeValue
    {
        public AttributeValue()
        {
            ProductPricesAttributeValueId1Navigation = new HashSet<ProductPrice>();
            ProductPricesAttributeValueId2Navigation = new HashSet<ProductPrice>();
        }

        public int Id { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual ICollection<ProductPrice> ProductPricesAttributeValueId1Navigation { get; set; }
        public virtual ICollection<ProductPrice> ProductPricesAttributeValueId2Navigation { get; set; }
    }
}

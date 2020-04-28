using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class AttributeValue : BaseEntity
    {
        public AttributeValue()
        {
            ProductPricesAttributeValueId1Navigation = new HashSet<ProductPrice>();
            ProductPricesAttributeValueId2Navigation = new HashSet<ProductPrice>();
        }

        public int AttributeId { get; set; }
        public string Value { get; set; }
        public int Status { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual ICollection<ProductPrice> ProductPricesAttributeValueId1Navigation { get; set; }
        public virtual ICollection<ProductPrice> ProductPricesAttributeValueId2Navigation { get; set; }
    }
}

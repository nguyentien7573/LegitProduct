using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class Attribute : BaseEntity
    {
        public Attribute()
        {
            AttributeValues = new HashSet<AttributeValue>();
        }

        public int ProductId { get; set; }
        
        public virtual Product Product { get; set; }
        public virtual ICollection<AttributeValue> AttributeValues { get; set; }
    }
}

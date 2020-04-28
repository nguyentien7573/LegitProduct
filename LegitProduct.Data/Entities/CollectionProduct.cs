using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class CollectionProduct : BaseEntity
    {
        public int ProductId { get; set; }
        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; }
        public virtual Product Product { get; set; }
    }
}

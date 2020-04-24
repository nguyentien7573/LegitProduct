using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Attribute
    {
        public Attribute()
        {
            AttributeValues = new HashSet<AttributeValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<AttributeValue> AttributeValues { get; set; }
    }
}

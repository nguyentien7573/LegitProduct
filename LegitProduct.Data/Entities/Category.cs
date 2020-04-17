using LegitProduct.Data.ObjectEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
        public List<Product_Category> Product_Category { get; set; }

    }
}

using LegitProduct.Data.ObjectEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.Category.Dtos
{
    public class CategoryCreateRequest
    {
        public string Name { get; set; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
    }
}

using LegitProduct.ApplicationLogic.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.Category.Dtos
{
    public class CategoryPagingRequest : PagingRequest
    {
        public string Keyword { get; set; }
        public int? ParentId { get; set; }
    }
}

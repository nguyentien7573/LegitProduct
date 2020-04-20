using LegitProduct.ApplicationLogic.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.Product.Dtos
{
    public class ProductPagingRequest : PagingRequest
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}

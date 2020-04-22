using LegitProduct.ApplicationLogic.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.ApplicationLogic.Catalog.Product.Dtos
{
    public class GetPublicProductPaging:PagingRequest
    {
        public int? CategoryId { get; set; }
    }
}

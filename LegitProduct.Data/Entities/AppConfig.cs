using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class AppConfig : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}

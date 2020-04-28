using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{ 
    public class Log : BaseEntity
    {
        public string TableName { get; set; }
        public string AppUserId { get; set; }
        public string Action { get; set; }
        public string Desciption { get; set; }
    }
}

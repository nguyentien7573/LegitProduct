using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{ 
    public partial class Log
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string AppUserId { get; set; }
        public string Action { get; set; }
        public string Desciption { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}

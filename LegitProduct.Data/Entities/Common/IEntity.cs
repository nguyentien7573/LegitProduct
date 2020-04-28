using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Entities.Common
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; } 
        public DateTime? DateUpdated { get; set; }
        public string CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }

    }
}

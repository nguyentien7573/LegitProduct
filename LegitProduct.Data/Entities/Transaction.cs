using LegitProduct.Data.Entities.Common;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class Transaction : BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public string ExternalTransactionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public string Provider { get; set; }
        public Guid UserId { get; set; }

        public virtual AppUser User { get; set; }
    }
}

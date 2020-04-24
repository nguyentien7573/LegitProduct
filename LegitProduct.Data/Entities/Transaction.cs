using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ExternalTransactionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public string Provider { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual AppUser User { get; set; }
    }
}

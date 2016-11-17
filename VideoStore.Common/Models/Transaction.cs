using System;
using System.Collections.Generic;

namespace VideoStore.Common.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<TransactionItem> TransactionItems { get; set; }
    }
}
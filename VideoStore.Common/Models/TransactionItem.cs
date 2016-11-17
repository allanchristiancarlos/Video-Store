using System;

namespace VideoStore.Common.Models
{
    public class TransactionItem
    {
        public int TransactionItemId { get; set; }
        public int TransactionId { get; set; }
        public virtual Transaction Transaction { get; set; }
        public bool Returned { get; set; }
        public DateTime? DateReturned { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public int DvdId { get; set; }
        public virtual Dvd Dvd { get; set; }
    }
}
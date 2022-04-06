using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            Payment = new HashSet<Payment>();
        }

        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal Total { get; set; }
        public decimal? Discount { get; set; }
        public decimal SubTotal { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}

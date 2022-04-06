using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}

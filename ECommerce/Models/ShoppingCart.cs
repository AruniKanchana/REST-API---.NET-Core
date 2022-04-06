using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class ShoppingCart
    {
        public int CartId { get; set; }
        public int OrderId { get; set; }
        public int NumberOfItems { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Order Order { get; set; }
    }
}

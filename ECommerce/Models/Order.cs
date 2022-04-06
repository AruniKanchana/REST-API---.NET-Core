using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class Order
    {
        public Order()
        {
            ShoppingCart = new HashSet<ShoppingCart>();
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCart { get; set; }
    }
}

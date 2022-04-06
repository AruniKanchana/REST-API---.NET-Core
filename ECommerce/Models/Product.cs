using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class Product
    {
        public Product()
        {
            Order = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int IsAvailable { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}

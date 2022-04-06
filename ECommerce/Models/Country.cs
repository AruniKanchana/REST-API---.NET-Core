using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class Country
    {
        public Country()
        {
            Customer = new HashSet<Customer>();
        }

        public int CountryCode { get; set; }
        public string CountryName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}

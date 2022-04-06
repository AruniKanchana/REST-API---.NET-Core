using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int CustomerId { get; set; }
        public int CountryCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual LoginCredentials LoginCredentials { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}

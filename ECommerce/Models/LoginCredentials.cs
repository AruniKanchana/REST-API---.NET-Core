using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public partial class LoginCredentials
    {
        public int CustomerId { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

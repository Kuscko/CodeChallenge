using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Core.Models.DomainModels
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int AddressId { get; set; } // foreign key property

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public Address Address { get; set; }

    }
}

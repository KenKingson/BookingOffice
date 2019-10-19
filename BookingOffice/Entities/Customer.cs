using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingOffice.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string MiddleName { get; set; }

        public Guid PassportCode { get; set; }

        public int PhoneNumber { get; set; }
    }
}

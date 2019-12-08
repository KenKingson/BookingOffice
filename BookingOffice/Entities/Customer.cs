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

        public string PassportCode { get; set; }

        public int PhoneNumber { get; set; }

		public Customer(string firstName, string secondName,
			string middleName, string passportCode, int phoneNumber)
		{
			Id = Guid.NewGuid();
			FirstName = firstName;
			SecondName = secondName;
			MiddleName = middleName;
			PassportCode = passportCode;
			PhoneNumber = phoneNumber;
		}

		public Customer() { }
    }
}

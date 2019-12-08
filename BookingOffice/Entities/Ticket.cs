using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingOffice.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public Guid FlightId { get; set; }

        public Guid CustomerId { get; set; }

        public int Price { get; set; }

        public DateTime DateOfPushcare { get; set; }

        public string FlightClass { get; set; }
		
		public Ticket(Guid flightId, Guid customerId, int price)
		{
			Id = Guid.NewGuid();
			FlightId = flightId;
			CustomerId = customerId;
			Price = price;
			DateOfPushcare = DateTime.Now;
			var classFlight = new string[] { "Первый класс", "Бизнес-класс", "Эконом" };
			FlightClass = classFlight[(new Random()).Next(0, 2)];
		}

		public Ticket() { }
    }
}

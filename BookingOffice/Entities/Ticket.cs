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

        public float Price { get; set; }

        public DateTime DateOfPushcare { get; set; }

        public FlightClass FlightClass { get; set; }
    }

    public enum FlightClass
    {
        FirstClass, BusinessClass, EconomClass
    }
}

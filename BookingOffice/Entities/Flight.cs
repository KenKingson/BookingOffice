using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingOffice.Entities
{
    public class Flight
    {
        public Guid Id { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime TimeFrom { get; set; }

        public DateTime DateTo { get; set; }

        public DateTime TimeTo { get; set; }

        public string Aircraft { get; set; }

        public string TimeZone { get; set; }

        public Flight() { }
        public Flight(Guid guid,string from, string to, DateTime dateFrom, DateTime timeFrom, 
            DateTime dateTo, DateTime timeTo, string aircraft, string timeZone)
        {

			Id = guid;
            From = from;
            To = to;
            DateFrom = dateFrom;
            TimeFrom = timeFrom;
            DateTo = dateTo;
            TimeTo = timeTo;
            Aircraft = aircraft;
            TimeZone = timeZone;
        }
    }
}

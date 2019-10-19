using BookingOffice.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingOffice.Containers
{
    public class ListOfFlights
    {
        private List<Flight> _flights = new List<Flight>();

        public List<Flight> Flights { get; set; }
        //TODO: Выполнить привязку данных
        //TODO: Необходимы данные, нужно создать наполнить таблицу

    }
}

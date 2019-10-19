using BookingOffice.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingOffice.Utils
{
    public class Context: DbContext
    {
        public Context() : base("DbConnection")
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        //TODO: Разобраться с Миграцией
    }
}

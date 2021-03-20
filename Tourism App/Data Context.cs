using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism_App
{
    class Data_Context : DbContext
    {

        public Data_Context():base("DefaultConnection")
        { }



        public DbSet<Employee> Employees { get; set; }
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passenger> Passengers { get; set; }


    }
}

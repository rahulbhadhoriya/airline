using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Airlines.Model
{
    public class FlightDb  :DbContext
    {
        public DbSet<Flight> Flights { get; set; }
    }
}
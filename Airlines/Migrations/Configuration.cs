using System.Collections.Generic;
using Airlines.Model;

namespace Airlines.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Airlines.Model.FlightDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Airlines.Model.FlightDb context)
        {
            if(!context.Flights.Any())
            {
             context.Flights.AddRange(
                new List<Flight>() {
                    new Flight()
                    {
                        Airline="Delta", Approved =false, 
                        Cities=new []{"ORD", "SFO"}, 
                        StartTime=DateTime.Now, 
                        EndTime = DateTime.Now,
                        TotalDuration = 8, 
                         Date = DateTime.Now,
                        Price = 300
                    },
                    new Flight()
                    {
                        Airline="JetBlue", Approved =false, 
                        Cities=new []{"ORD", "SFO"}, 
                        StartTime=DateTime.Now, 
                        EndTime=DateTime.Now,
                        Date = DateTime.Now,
                        TotalDuration = 8, Price = 500
                    }
                });  
            }
        }
    }
}

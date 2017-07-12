using System;
using System.Collections.Generic;
using System.Web.Http;
using Airlines.Model;

namespace Airlines.Controllers
{
    public class FlightsController : ApiController
    {
        public IHttpActionResult GetAllFlights()
        {
            var db = new FlightDb();            
            return Ok(db.Flights);
        }
    }

    
}
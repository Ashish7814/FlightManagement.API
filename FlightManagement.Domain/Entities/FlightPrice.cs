using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Domain.Entities
{
    public class FlightPrice
    {
        public int Id { get; set; }

        public int FlightId { get; set; }
        public int TemplateId { get; set; }

        public string ClassType { get; set; } // Economy, Business, First

        public decimal Price { get; set; }

        public Flight Flight { get; set; }
        public FlightScheduleTemplate FlightTemplate { get; set; }
    }
}

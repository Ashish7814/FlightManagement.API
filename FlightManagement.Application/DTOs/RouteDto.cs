using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Application.DTOs
{
    public class RouteDto
    {
        public int RouteId { get; set; }
        public string RouteCode { get; set; }

        public int OriginAirportId { get; set; }
        public int DestinationAirportId { get; set; }

        public int Distance { get; set; }
        public int EstimatedDuration { get; set; }

        public AirportDto OriginAirport { get; set; }
        public AirportDto DestinationAirport { get; set; }

        public List<FlightDto> Flights { get; set; }
        public int TotalRecords { get; set; }
    }

}

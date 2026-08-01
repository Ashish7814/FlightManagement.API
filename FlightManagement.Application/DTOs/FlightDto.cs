using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Application.DTOs
{
    public class FlightDto
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }

        public int RouteId { get; set; }
        public int AircraftId { get; set; }

        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }

        public DateTime? ActualDepartureDateTime { get; set; }
        public DateTime? ActualArrivalDateTime { get; set; }

        public string FlightStatus { get; set; }

        public string DepartureGate { get; set; }
        public string ArrivalGate { get; set; }

        public decimal EconomyPrice { get; set; }
        public decimal BusinessPrice { get; set; }
        public decimal FirstClassPrice { get; set; }

        public int AvailableEconomySeats { get; set; }
        public int AvailableBusinessSeats { get; set; }
        public int AvailableFirstClassSeats { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int TotalRecords { get; set; }

        // Navigation
        public RouteDto Route { get; set; }
        public AircraftDto Aircraft { get; set; }
    }
  
}

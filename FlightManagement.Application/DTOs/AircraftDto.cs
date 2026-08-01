using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Application.DTOs
{
    public class AircraftDto
    {
        public int AircraftId { get; set; }
        public string RegistrationNumber { get; set; }
        public string AircraftType { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
        public int EconomySeats { get; set; }
        public int BusinessSeats { get; set; }
        public int FirstClassSeats { get; set; }
        public int TotalSeats { get; set; }
        public string CurrentStatus { get; set; } // Available, InFlight, Maintenance, OutOfService
        public DateTime LastMaintenanceDate { get; set; }
        public DateTime NextMaintenanceDate { get; set; }
        public bool IsActive { get; set; }
        public string CurrentLocation { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AircraftAge { get; set; }
        public int TotalRecords { get; set; }
        public List<FlightDto> Flights { get; set; }
        public List<MaintenanceRecordDto> MaintenanceRecordDtos { get; set; }
    }

}
